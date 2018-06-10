using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class ResearchSamples : ISampleProjects
    {
        
        public ResearchSamples()
        {
            Initilize();
        }

        public List<SampleProject> Samples { get ; set; }



        // we need to add relevant projects
        public void Initilize()
        {
            
        }
    }
}