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
    public class pacientesController : ApiController
    {
        private hospitalpoliEntities1 db = new hospitalpoliEntities1();

        // GET: api/pacientes
        public IQueryable<pacientes> Getpacientes()
        {
            return db.pacientes;
        }

        // GET: api/pacientes/5
        [ResponseType(typeof(pacientes))]
        public IHttpActionResult Getpacientes(long id)
        {
            pacientes pacientes = db.pacientes.Find(id);
            if (pacientes == null)
            {
                return NotFound();
            }

            return Ok(pacientes);
        }

        // PUT: api/pacientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putpacientes(long id, pacientes pacientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pacientes.id_paciente)
            {
                return BadRequest();
            }

            db.Entry(pacientes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pacientesExists(id))
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

        // POST: api/pacientes
        [ResponseType(typeof(pacientes))]
        public IHttpActionResult Postpacientes(pacientes pacientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.pacientes.Add(pacientes);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (pacientesExists(pacientes.id_paciente))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pacientes.id_paciente }, pacientes);
        }

        // DELETE: api/pacientes/5
        [ResponseType(typeof(pacientes))]
        public IHttpActionResult Deletepacientes(long id)
        {
            pacientes pacientes = db.pacientes.Find(id);
            if (pacientes == null)
            {
                return NotFound();
            }

            db.pacientes.Remove(pacientes);
            db.SaveChanges();

            return Ok(pacientes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool pacientesExists(long id)
        {
            return db.pacientes.Count(e => e.id_paciente == id) > 0;
        }
    }
}