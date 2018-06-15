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
using FinedProjectApp.Models;

namespace FinedProjectApp.Controllers
{
    public class StudentPrefsController : ApiController
    {

        // GET: api/StudentPrefs
        /*public IQueryable<StudentPref> GetStudentPrefs()
        {
            return db.StudentPrefs;
        }

        // GET: api/StudentPrefs/5
        [ResponseType(typeof(StudentPref))]
        public IHttpActionResult GetStudentPref(string id)
        {
            StudentPref studentPref = db.StudentPrefs.Find(id);
            if (studentPref == null)
            {
                return NotFound();
            }

            return Ok(studentPref);
        }

        // PUT: api/StudentPrefs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudentPref(string id, StudentPref studentPref)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentPref.UserName)
            {
                return BadRequest();
            }

            db.Entry(studentPref).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentPrefExists(id))
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

        // POST: api/StudentPrefs
        [ResponseType(typeof(StudentPref))]
        public void PostStudentPref(StudentPref studentPref)
        {
            if (!Moderators.ModStudentPref.SetStudentPref(studentPref))
            {

                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/StudentPrefs/5
        [ResponseType(typeof(StudentPref))]
        public IHttpActionResult DeleteStudentPref(string id)
        {
            StudentPref studentPref = db.StudentPrefs.Find(id);
            if (studentPref == null)
            {
                return NotFound();
            }

            db.StudentPrefs.Remove(studentPref);
            db.SaveChanges();

            return Ok(studentPref);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentPrefExists(string id)
        {
            return db.StudentPrefs.Count(e => e.UserName == id) > 0;
        }*/
    }
}