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

		// GET: api/Students
		public void GetStudents()
		{

		}

		// GET: api/Students/5
		[ResponseType(typeof(Student))]
		public void GetStudent(int id)
		{

		}

		// PUT: api/Students/5
		[ResponseType(typeof(void))]
		public void PutStudent(int id, Student student)
		{

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
        public void DeleteProjectDirec(string id)
        {
            
        }

       
    }
}