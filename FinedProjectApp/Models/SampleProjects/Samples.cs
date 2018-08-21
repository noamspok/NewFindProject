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
            SamplesList.Add(new SampleProject("java,c,c++", "industry","1","???"));
            SamplesList.Add(new SampleProject("C#,sql", "industry", "1", "aplication"));
            SamplesList.Add(new SampleProject("C++,python", "industry", "2", "aplication;AI;ml"));
            SamplesList.Add(new SampleProject("angular,python,JS", "industry", "2", "aplication;AI;ml"));
            
        }
    }
}