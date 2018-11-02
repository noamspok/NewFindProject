using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace FinedProjectApp.Controllers
{
    public class FileController : ApiController
    {
        // GET api/File
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/File/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/File
        [HttpPost]
        public string MyFileUpload()
        {
            var request = HttpContext.Current.Request;
            var filePath = "C:\\Users\\maor\\Source\\Repos\\NewFindProject\\FinedProjectApp\\files\\exsamples\\" + request.Headers["X-File-Name"];
            using (var fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                request.InputStream.CopyTo(fs);
            }
            if (!Repositories.Projects.updateProjectLocation(request.Headers["X-Project-Name"], filePath))
            {

            }
            return "uploaded";
        }

        // PUT api/File/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/File/5
        public void Delete(int id)
        {
        }
    }
}