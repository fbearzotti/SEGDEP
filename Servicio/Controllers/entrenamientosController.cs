using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using Servicio.Datos;

namespace Servicio.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using Servicio.Datos;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<entrenamientos>("entrenamientos");
    builder.EntitySet<asistenciaEntrenamientos>("asistenciaEntrenamientos"); 
    builder.EntitySet<categorias>("categorias"); 
    builder.EntitySet<climas>("climas"); 
    builder.EntitySet<tipoSesion>("tipoSesion"); 
    builder.EntitySet<estadoCampos>("estadoCampos"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class entrenamientosController : ODataController
    {
        private SEGDEPWEntities db = new SEGDEPWEntities();

        // GET: odata/entrenamientos
        [EnableQuery]
        public IQueryable<entrenamientos> Getentrenamientos()
        {
            return db.entrenamientos;
        }

        // GET: odata/entrenamientos(5)
        [EnableQuery]
        public SingleResult<entrenamientos> Getentrenamientos([FromODataUri] int key)
        {
            return SingleResult.Create(db.entrenamientos.Where(entrenamientos => entrenamientos.ID == key));
        }

        // PUT: odata/entrenamientos(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<entrenamientos> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entrenamientos entrenamientos = db.entrenamientos.Find(key);
            if (entrenamientos == null)
            {
                return NotFound();
            }

            patch.Put(entrenamientos);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!entrenamientosExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(entrenamientos);
        }

        // POST: odata/entrenamientos
        public IHttpActionResult Post(entrenamientos entrenamientos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.entrenamientos.Add(entrenamientos);
            db.SaveChanges();

            return Created(entrenamientos);
        }

        // PATCH: odata/entrenamientos(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<entrenamientos> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entrenamientos entrenamientos = db.entrenamientos.Find(key);
            if (entrenamientos == null)
            {
                return NotFound();
            }

            patch.Patch(entrenamientos);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!entrenamientosExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(entrenamientos);
        }

        // DELETE: odata/entrenamientos(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            entrenamientos entrenamientos = db.entrenamientos.Find(key);
            if (entrenamientos == null)
            {
                return NotFound();
            }

            db.entrenamientos.Remove(entrenamientos);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/entrenamientos(5)/asistenciaEntrenamientos
        [EnableQuery]
        public IQueryable<asistenciaEntrenamientos> GetasistenciaEntrenamientos([FromODataUri] int key)
        {
            return db.entrenamientos.Where(m => m.ID == key).SelectMany(m => m.asistenciaEntrenamientos);
        }

        // GET: odata/entrenamientos(5)/categorias
        [EnableQuery]
        public SingleResult<categorias> Getcategorias([FromODataUri] int key)
        {
            return SingleResult.Create(db.entrenamientos.Where(m => m.ID == key).Select(m => m.categorias));
        }

        // GET: odata/entrenamientos(5)/climas
        [EnableQuery]
        public SingleResult<climas> Getclimas([FromODataUri] int key)
        {
            return SingleResult.Create(db.entrenamientos.Where(m => m.ID == key).Select(m => m.climas));
        }

        // GET: odata/entrenamientos(5)/tipoSesion
        [EnableQuery]
        public SingleResult<tipoSesion> GettipoSesion([FromODataUri] int key)
        {
            return SingleResult.Create(db.entrenamientos.Where(m => m.ID == key).Select(m => m.tipoSesion));
        }

        // GET: odata/entrenamientos(5)/estadoCampos
        [EnableQuery]
        public SingleResult<estadoCampos> GetestadoCampos([FromODataUri] int key)
        {
            return SingleResult.Create(db.entrenamientos.Where(m => m.ID == key).Select(m => m.estadoCampos));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool entrenamientosExists(int key)
        {
            return db.entrenamientos.Count(e => e.ID == key) > 0;
        }
    }
}
