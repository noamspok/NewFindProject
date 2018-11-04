using FinedProjectApp.Moderators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinedProjectApp.Controllers
{
    public class FinalProjectsController : ApiController
    {
        // GET: api/FinalProjects
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FinalProjects/5
        public void Get(string user)
        {
			List < string> projects= ModFinalProposal.GetFinalProjects(user);
			foreach (var path  in projects)
			{
				//לשלוח את כל הפרויקטים
			}
        }

        // POST: api/FinalProjects
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FinalProjects/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FinalProjects/5
        public void Delete(int id)
        {
        }
    }
}
