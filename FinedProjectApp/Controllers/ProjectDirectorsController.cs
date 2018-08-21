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
    public class ProjectDirectorsController : ApiController
    {

		// GET: api/Students
		public void GetStudents()
		{

		}

		// GET: api/Students/5/password
		[HttpGet()]
		public void GetDirector(string username,string password)
		{
			var message = Repositories.SignInQuery.DirectorSignIn(username, password);
			if(message=="ok")
				return;
			var response = new HttpResponseMessage()
			{
				StatusCode = HttpStatusCode.BadRequest,
				ReasonPhrase = message
			};
			throw new HttpResponseException(response);
		}

		// PUT: api/Students/5
		
		public void PutStudent(int id, Student student)
		{

		}

		// POST: api/ProjectDirectors
		[HttpPost()]
		public void PostDirec(Director director)
		{
            SHA1 hash = new SHA1CryptoServiceProvider();
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(director.Password);
            byte[] compPass = hash.ComputeHash(pass);
            string password = System.Text.Encoding.Default.GetString(compPass);
            if (!Moderators.ModDirector.SetDirector(director.UserName, password, director.Email))
			{

				throw new HttpResponseException(HttpStatusCode.Forbidden);
			}
		}
        /*
		// POST: api/ProjectDirectors/bbb
		[ResponseType(typeof(ProjectDirec))]
		[HttpPost()]
		public void PostProject(ProjectDirec projectDirec)
        {
			if (!Moderators.ModDirector.SetProject(projectDirec))
			{

				throw new HttpResponseException(HttpStatusCode.BadRequest);
			}
		}
        */
        // DELETE: api/ProjectDirectors/5
        [ResponseType(typeof(ProjectDirec))]
        public void DeleteProjectDirec(string id)
        {
            
        }

       
    }
}