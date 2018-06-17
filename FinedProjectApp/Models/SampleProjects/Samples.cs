using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class Samples : ISampleProjects
    {
        
        public Samples()
        {
            Initilize();
        }

        public List<SampleProject> SamplesList { get ; set; }



        // we need to add relevant projects
        public void Initilize()
        {
			SamplesList.Add( new SampleProject("python", "research", "1", "machine learning"));

		}
    }
}