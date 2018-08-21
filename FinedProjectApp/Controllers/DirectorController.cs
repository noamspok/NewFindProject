using System;
using System.Collections.Generic;
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
    public class DirectorController : ApiController
    {
        // GET: api/Director
        public void Get()
        {
        }

        [HttpGet()]
        public string GetDirector(string username, string password)
        {
            SHA1 hash = new SHA1CryptoServiceProvider();
            byte[] pass = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] compPass = hash.ComputeHash(pass);
            password = System.Text.Encoding.Default.GetString(compPass);
            var message = Repositories.SignInQuery.DirectorSignIn(username, password);
            if (message == "ok")
                return message;
            var response = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.BadRequest,
                ReasonPhrase = message
            };
            throw new HttpResponseException(response);
        }

        // POST: api/Director
        [HttpPost()]
        public void Post(Director director)
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

        // PUT: api/Director/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Director/5
        public void Delete(int id)
        {
        }
    }
}
