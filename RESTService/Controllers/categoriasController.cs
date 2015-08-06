using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using RESTService.Datos;

namespace RESTService.Controllers
{
    [Authorize]
    public class categoriasController : ODataController
    {
        private SEGDEPWEntities db = new SEGDEPWEntities();

        // GET: odata/categorias
        [EnableQuery]
        public IQueryable<categorias> Getcategorias()
        {
            return db.categorias;
        }

        // GET: odata/categorias(5)
        [EnableQuery]
        public SingleResult<categorias> Getcategorias([FromODataUri] int key)
        {
            return SingleResult.Create(db.categorias.Where(categorias => categorias.ID == key));
        }

        // PUT: odata/categorias(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<categorias> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            categorias categorias = await db.categorias.FindAsync(key);
            if (categorias == null)
            {
                return NotFound();
            }

            patch.Put(categorias);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!categoriasExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(categorias);
        }

        // POST: odata/categorias
        public async Task<IHttpActionResult> Post(categorias categorias)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.categorias.Add(categorias);
            await db.SaveChangesAsync();

            return Created(categorias);
        }

        // PATCH: odata/categorias(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<categorias> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            categorias categorias = await db.categorias.FindAsync(key);
            if (categorias == null)
            {
                return NotFound();
            }

            patch.Patch(categorias);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!categoriasExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(categorias);
        }

        // DELETE: odata/categorias(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            categorias categorias = await db.categorias.FindAsync(key);
            if (categorias == null)
            {
                return NotFound();
            }

            db.categorias.Remove(categorias);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/categorias(5)/temporadas
        [EnableQuery]
        public SingleResult<temporadas> Gettemporadas([FromODataUri] int key)
        {
            return SingleResult.Create(db.categorias.Where(m => m.ID == key).Select(m => m.temporadas));
        }

        // GET: odata/categorias(5)/categoriasPersonas
        [EnableQuery]
        public IQueryable<categoriasPersonas> GetcategoriasPersonas([FromODataUri] int key)
        {
            return db.categorias.Where(m => m.ID == key).SelectMany(m => m.categoriasPersonas);
        }

        // GET: odata/categorias(5)/eventos
        [EnableQuery]
        public IQueryable<eventos> Geteventos([FromODataUri] int key)
        {
            return db.categorias.Where(m => m.ID == key).SelectMany(m => m.eventos);
        }

        // GET: odata/categorias(5)/medidas
        [EnableQuery]
        public IQueryable<medidas> Getmedidas([FromODataUri] int key)
        {
            return db.categorias.Where(m => m.ID == key).SelectMany(m => m.medidas);
        }

        // GET: odata/categorias(5)/partidos
        [EnableQuery]
        public IQueryable<partidos> Getpartidos([FromODataUri] int key)
        {
            return db.categorias.Where(m => m.ID == key).SelectMany(m => m.partidos);
        }

        // GET: odata/categorias(5)/entrenadores
        [EnableQuery]
        public SingleResult<entrenadores> Getentrenadores([FromODataUri] int key)
        {
            return SingleResult.Create(db.categorias.Where(m => m.ID == key).Select(m => m.entrenadores));
        }

        // GET: odata/categorias(5)/entrenamientos
        [EnableQuery]
        public IQueryable<entrenamientos> Getentrenamientos([FromODataUri] int key)
        {
            return db.categorias.Where(m => m.ID == key).SelectMany(m => m.entrenamientos);
        }

        // GET: odata/categorias(5)/jugadores
        [EnableQuery]
        public IQueryable<jugadores> Getjugadores([FromODataUri] int key)
        {
            return db.categorias.Where(m => m.ID == key).SelectMany(m => m.jugadores);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool categoriasExists(int key)
        {
            return db.categorias.Count(e => e.ID == key) > 0;
        }
    }
}
