using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GrupoFamiliarPoli.Models.DataBase;

namespace GrupoFamiliarPoli.Controllers
{
    public class grupo_familiarController : ApiController
    {
        private hospitalpoliEntities1 db = new hospitalpoliEntities1();

        // GET: api/grupo_familiar
        public IQueryable<grupo_familiar> Getgrupo_familiar()
        {
            return db.grupo_familiar;
        }

        // GET: api/grupo_familiar/5
        [ResponseType(typeof(grupo_familiar))]
        public IHttpActionResult Getgrupo_familiar(int id)
        {
            var query = (from a in db.pacientes
                         where a.id_paciente == id
                         select a).FirstOrDefault();
            if (query != null)
            {

            }
            grupo_familiar grupo_familiar = db.grupo_familiar.Find(id);
            if (grupo_familiar == null)
            {
                return NotFound();
            }

            return Ok(grupo_familiar);
        }

        // PUT: api/grupo_familiar/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putgrupo_familiar(int id, grupo_familiar grupo_familiar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != grupo_familiar.id_familiar)
            {
                return BadRequest();
            }

            db.Entry(grupo_familiar).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!grupo_familiarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/grupo_familiar
        [ResponseType(typeof(grupo_familiar))]
        public IHttpActionResult Postgrupo_familiar(grupo_familiar grupo_familiar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.grupo_familiar.Add(grupo_familiar);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = grupo_familiar.id_familiar }, grupo_familiar);
        }

        // DELETE: api/grupo_familiar/5
        [ResponseType(typeof(grupo_familiar))]
        public IHttpActionResult Deletegrupo_familiar(int id)
        {
            grupo_familiar grupo_familiar = db.grupo_familiar.Find(id);
            if (grupo_familiar == null)
            {
                return NotFound();
            }

            db.grupo_familiar.Remove(grupo_familiar);
            db.SaveChanges();

            return Ok(grupo_familiar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool grupo_familiarExists(int id)
        {
            return db.grupo_familiar.Count(e => e.id_familiar == id) > 0;
        }
    }
}