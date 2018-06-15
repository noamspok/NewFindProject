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
    public class ProjectDirectorsController : ApiController
    {

        // GET: api/ProjectDirectors
       /* public IQueryable<ProjectDirec> GetProjectDirecs()
        {
            
        }

        // GET: api/ProjectDirectors/5
        [ResponseType(typeof(ProjectDirec))]
        public IHttpActionResult GetProjectDirec(string id)
        {
            ProjectDirec projectDirec = db.ProjectDirecs.Find(id);
            if (projectDirec == null)
            {
                return NotFound();
            }

            return Ok(projectDirec);
        }

        // PUT: api/ProjectDirectors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProjectDirec(string id, ProjectDirec projectDirec)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != projectDirec.UserName)
            {
                return BadRequest();
            }
            

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectDirecExists(id))
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

        // POST: api/ProjectDirectors
        [ResponseType(typeof(ProjectDirec))]
		[HttpPost()]
		public void PostProjectDirec(ProjectDirec projectDirec)
        {
			if (!Moderators.ModDirector.SetDirector(projectDirec))
			{

				throw new HttpResponseException(HttpStatusCode.BadRequest);
			}
		}

        // DELETE: api/ProjectDirectors/5
        [ResponseType(typeof(ProjectDirec))]
        public IHttpActionResult DeleteProjectDirec(string id)
        {
            ProjectDirec projectDirec = db.ProjectDirecs.Find(id);
            if (projectDirec == null)
            {
                return NotFound();
            }

            db.ProjectDirecs.Remove(projectDirec);
            db.SaveChanges();

            return Ok(projectDirec);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProjectDirecExists(string id)
        {
            return db.ProjectDirecs.Count(e => e.UserName == id) > 0;
        }*/
    }
}