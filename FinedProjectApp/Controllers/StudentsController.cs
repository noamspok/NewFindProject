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

namespace FinedProjectApp.Controllers
{
    public class StudentsController : ApiController
    {

      // GET: api/Students
        public void GetStudents()
        {
           
        }

		[HttpGet()]
		public void GetStudent(string name, string password)
		{
			var message = Repositories.SignInQuery.SignIn(name, password);
			if (message == "ok")
				return;
			var response = new HttpResponseMessage()
			{
				StatusCode = HttpStatusCode.BadRequest,
				ReasonPhrase = message
			};
			throw new HttpResponseException(response);
		}

		// PUT: api/Students/5
		[ResponseType(typeof(void))]
        public void PutStudent(int id, Student student)
        {
            
        }

        // POST: api/Students
        [ResponseType(typeof(Student))]
        [HttpPost()]
        public void PostStudent(Student student)
        {
            SHA1 hash = new SHA1CryptoServiceProvider();
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(student.Password);
            byte[] compPass = hash.ComputeHash(pass);
            string password = System.Text.Encoding.Default.GetString(compPass);
            if (!Moderators.ModStudent.SetStudent(student, password))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Student))]
        public void DeleteStudent(int id)
        {
            
        }

       
    }
}