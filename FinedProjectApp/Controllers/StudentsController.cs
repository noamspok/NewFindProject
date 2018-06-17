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

        // POST: api/Students
        [ResponseType(typeof(Student))]
        [HttpPost()]
        public void PostStudent(Student student)
        {
            /*SHA1 hash = new SHA1CryptoServiceProvider();
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(student.Password);
            byte[] compPass = hash.ComputeHash(pass);
            student.Password = System.Text.Encoding.Default.GetString(compPass);*/
            if (!Moderators.ModStudent.SetStudent(student))
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