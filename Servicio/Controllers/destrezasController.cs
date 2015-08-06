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
    builder.EntitySet<destrezas>("destrezas");
    builder.EntitySet<destrezasGrupos>("destrezasGrupos"); 
    builder.EntitySet<destrezasNiveles>("destrezasNiveles"); 
    builder.EntitySet<destrezasPersonas>("destrezasPersonas"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class destrezasController : ODataController
    {
        private SEGDEPWEntities db = new SEGDEPWEntities();

        // GET: odata/destrezas
        [EnableQuery]
        public IQueryable<destrezas> Getdestrezas()
        {
            return db.destrezas;
        }

        // GET: odata/destrezas(5)
        [EnableQuery]
        public SingleResult<destrezas> Getdestrezas([FromODataUri] int key)
        {
            return SingleResult.Create(db.destrezas.Where(destrezas => destrezas.ID == key));
        }

        // PUT: odata/destrezas(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<destrezas> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            destrezas destrezas = db.destrezas.Find(key);
            if (destrezas == null)
            {
                return NotFound();
            }

            patch.Put(destrezas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!destrezasExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(destrezas);
        }

        // POST: odata/destrezas
        public IHttpActionResult Post(destrezas destrezas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.destrezas.Add(destrezas);
            db.SaveChanges();

            return Created(destrezas);
        }

        // PATCH: odata/destrezas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<destrezas> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            destrezas destrezas = db.destrezas.Find(key);
            if (destrezas == null)
            {
                return NotFound();
            }

            patch.Patch(destrezas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!destrezasExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(destrezas);
        }

        // DELETE: odata/destrezas(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            destrezas destrezas = db.destrezas.Find(key);
            if (destrezas == null)
            {
                return NotFound();
            }

            db.destrezas.Remove(destrezas);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/destrezas(5)/destrezasGrupos
        [EnableQuery]
        public SingleResult<destrezasGrupos> GetdestrezasGrupos([FromODataUri] int key)
        {
            return SingleResult.Create(db.destrezas.Where(m => m.ID == key).Select(m => m.destrezasGrupos));
        }

        // GET: odata/destrezas(5)/destrezasNiveles
        [EnableQuery]
        public SingleResult<destrezasNiveles> GetdestrezasNiveles([FromODataUri] int key)
        {
            return SingleResult.Create(db.destrezas.Where(m => m.ID == key).Select(m => m.destrezasNiveles));
        }

        // GET: odata/destrezas(5)/destrezasPersonas
        [EnableQuery]
        public IQueryable<destrezasPersonas> GetdestrezasPersonas([FromODataUri] int key)
        {
            return db.destrezas.Where(m => m.ID == key).SelectMany(m => m.destrezasPersonas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool destrezasExists(int key)
        {
            return db.destrezas.Count(e => e.ID == key) > 0;
        }
    }
}
