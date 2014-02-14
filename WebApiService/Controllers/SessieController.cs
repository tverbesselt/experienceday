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
using System.Web.Http.Description;
using BLL;

namespace WebApiService.Controllers
{
    public class SessieController : ApiController
    {
        private SessieContext db = new SessieContext();

        // GET api/Sessie
        public IQueryable<Sessie> GetSessies()
        {
            return db.Sessies;
        }

        // GET api/Sessie/5
        [ResponseType(typeof(Sessie))]
        public async Task<IHttpActionResult> GetSessie(int id)
        {
            Sessie sessie = await db.Sessies.FindAsync(id);
            if (sessie == null)
            {
                return NotFound();
            }

            return Ok(sessie);
        }

        // PUT api/Sessie/5
        public async Task<IHttpActionResult> PutSessie(int id, Sessie sessie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sessie.Id)
            {
                return BadRequest();
            }

            db.Entry(sessie).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SessieExists(id))
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

        // POST api/Sessie
        [ResponseType(typeof(Sessie))]
        public async Task<IHttpActionResult> PostSessie(Sessie sessie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sessies.Add(sessie);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sessie.Id }, sessie);
        }

        // DELETE api/Sessie/5
        [ResponseType(typeof(Sessie))]
        public async Task<IHttpActionResult> DeleteSessie(int id)
        {
            Sessie sessie = await db.Sessies.FindAsync(id);
            if (sessie == null)
            {
                return NotFound();
            }

            db.Sessies.Remove(sessie);
            await db.SaveChangesAsync();

            return Ok(sessie);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SessieExists(int id)
        {
            return db.Sessies.Count(e => e.Id == id) > 0;
        }
    }
}