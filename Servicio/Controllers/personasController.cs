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
    builder.EntitySet<personas>("personas");
    builder.EntitySet<asistenciaEntrenamientos>("asistenciaEntrenamientos"); 
    builder.EntitySet<categoriasPersonas>("categoriasPersonas"); 
    builder.EntitySet<clubes>("clubes"); 
    builder.EntitySet<destrezasPersonas>("destrezasPersonas"); 
    builder.EntitySet<eventos>("eventos"); 
    builder.EntitySet<localidades>("localidades"); 
    builder.EntitySet<pagos>("pagos"); 
    builder.EntitySet<salud>("salud"); 
    builder.EntitySet<tipoPersonas>("tipoPersonas"); 
    builder.EntitySet<posicionesPersonas>("posicionesPersonas"); 
    builder.EntitySet<tipoDocumentos>("tipoDocumentos"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class personasController : ODataController
    {
        private SEGDEPWEntities db = new SEGDEPWEntities();

        // GET: odata/personas
        [EnableQuery]
        public IQueryable<personas> Getpersonas()
        {
            return db.personas;
        }

        // GET: odata/personas(5)
        [EnableQuery]
        public SingleResult<personas> Getpersonas([FromODataUri] int key)
        {
            return SingleResult.Create(db.personas.Where(personas => personas.ID == key));
        }

        // PUT: odata/personas(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<personas> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            personas personas = db.personas.Find(key);
            if (personas == null)
            {
                return NotFound();
            }

            patch.Put(personas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!personasExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(personas);
        }

        // POST: odata/personas
        public IHttpActionResult Post(personas personas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.personas.Add(personas);
            db.SaveChanges();

            return Created(personas);
        }

        // PATCH: odata/personas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<personas> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            personas personas = db.personas.Find(key);
            if (personas == null)
            {
                return NotFound();
            }

            patch.Patch(personas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!personasExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(personas);
        }

        // DELETE: odata/personas(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            personas personas = db.personas.Find(key);
            if (personas == null)
            {
                return NotFound();
            }

            db.personas.Remove(personas);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/personas(5)/asistenciaEntrenamientos
        [EnableQuery]
        public IQueryable<asistenciaEntrenamientos> GetasistenciaEntrenamientos([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.asistenciaEntrenamientos);
        }

        // GET: odata/personas(5)/categoriasPersonas
        [EnableQuery]
        public IQueryable<categoriasPersonas> GetcategoriasPersonas([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.categoriasPersonas);
        }

        // GET: odata/personas(5)/clubes
        [EnableQuery]
        public SingleResult<clubes> Getclubes([FromODataUri] int key)
        {
            return SingleResult.Create(db.personas.Where(m => m.ID == key).Select(m => m.clubes));
        }

        // GET: odata/personas(5)/destrezasPersonas
        [EnableQuery]
        public IQueryable<destrezasPersonas> GetdestrezasPersonas([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.destrezasPersonas);
        }

        // GET: odata/personas(5)/eventos
        [EnableQuery]
        public IQueryable<eventos> Geteventos([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.eventos);
        }

        // GET: odata/personas(5)/localidades
        [EnableQuery]
        public SingleResult<localidades> Getlocalidades([FromODataUri] int key)
        {
            return SingleResult.Create(db.personas.Where(m => m.ID == key).Select(m => m.localidades));
        }

        // GET: odata/personas(5)/pagos
        [EnableQuery]
        public IQueryable<pagos> Getpagos([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.pagos);
        }

        // GET: odata/personas(5)/salud
        [EnableQuery]
        public IQueryable<salud> Getsalud([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.salud);
        }

        // GET: odata/personas(5)/tipoPersonas
        [EnableQuery]
        public SingleResult<tipoPersonas> GettipoPersonas([FromODataUri] int key)
        {
            return SingleResult.Create(db.personas.Where(m => m.ID == key).Select(m => m.tipoPersonas));
        }

        // GET: odata/personas(5)/posicionesPersonas
        [EnableQuery]
        public IQueryable<posicionesPersonas> GetposicionesPersonas([FromODataUri] int key)
        {
            return db.personas.Where(m => m.ID == key).SelectMany(m => m.posicionesPersonas);
        }

        // GET: odata/personas(5)/tipoDocumentos
        [EnableQuery]
        public SingleResult<tipoDocumentos> GettipoDocumentos([FromODataUri] int key)
        {
            return SingleResult.Create(db.personas.Where(m => m.ID == key).Select(m => m.tipoDocumentos));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool personasExists(int key)
        {
            return db.personas.Count(e => e.ID == key) > 0;
        }
    }
}
