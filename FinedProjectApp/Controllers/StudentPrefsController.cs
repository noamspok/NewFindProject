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
	private Samples samp=new Samples();
        // GET: api/StudentPrefs
        public void GetStudentPrefs()
        {
            
        }

        // GET: api/StudentPrefs/5
        [ResponseType(typeof(StudentPref))]
        public void GetStudentPref(string id)
        {
           
        }

        // PUT: api/StudentPrefs/5
       
        public void PutSampleResults(SampleProjectResults samplesResult)
        {
			if (!Moderators.ModSampleProject.UpdateTables(samp,samplesResult))
			{

				throw new HttpResponseException(HttpStatusCode.BadRequest);
			}
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
        public void DeleteStudentPref(string id)
        {
            
        }

        
    }
}