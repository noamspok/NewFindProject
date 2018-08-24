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
using System.Security.Cryptography;
using FinedProjectApp.Models.Users;

namespace FinedProjectApp.Controllers
{
    public class ProjectController : ApiController
    {


        // GET: api/Project
        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns>List&lt;User&gt;.</returns>
        [HttpGet()]
        public List<string> GetProjects(string username) { 
            List<string> projectList = Repositories.Projects.getProjectsNames(username);
            return projectList;
        }



        // PUT: api/Students/5

        public void PutStudent(int id, Student student)
		{

		}

        
		// POST: api/Project
		[ResponseType(typeof(Project))]
		[HttpPost()]
		public void PostProject(Project project)
        {
			if (!Moderators.ModProject.SetProject(project))
			{

				throw new HttpResponseException(HttpStatusCode.BadRequest);
			}
		}
        
        // DELETE: api/Project/5
        [ResponseType(typeof(Project))]
        public void DeleteProjectDirec(string id)
        {
            
        }

       
    }
}