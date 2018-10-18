using FinedProjectApp.Models.SampleProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinedProjectApp.Controllers
{
    public class SurveyController : ApiController
    {
        // GET: api/Survey
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Survey/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Survey
        public void Post(SurveyResult surveyResult)
        {
            if (!Moderators.ModSurvey.UpdateTables(surveyResult))
            {

                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Survey/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Survey/5
        public void Delete(int id)
        {
        }
    }
}
