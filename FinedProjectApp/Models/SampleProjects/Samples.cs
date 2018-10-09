using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class Samples
    {
        private List<SampleProject> SamplesList;


        public Samples()
        {
            this.SamplesList = new List<SampleProject>();
            SamplesList.Add(new SampleProject("research", "ML,AI,Web" , "JS,Java" , "3"));
            SamplesList.Add(new SampleProject("research","Cyber" , "C" , "1"));
            SamplesList.Add(new SampleProject("research", "aplication",  "angular,Swift" , "2"));
            SamplesList.Add(new SampleProject("research",  "AI, Web" ,  "JS,C#, sql" , "2"));
            SamplesList.Add(new SampleProject("research", "Cyber, Web" ,  "JS,python" , "1"));
            SamplesList.Add(new SampleProject("industry", "aplication", "angular,sql", "2"));
            SamplesList.Add(new SampleProject("industry", "Web,AI" ,"JS,C#,sql", "2"));
            SamplesList.Add(new SampleProject("industry", "aplication","Swift,angular" , "1"));
            SamplesList.Add(new SampleProject("industry", "aplication" , "Swift,angular", "2"));
            SamplesList.Add(new SampleProject("industry", "ML", "python,JS", "4"));

        }
        public List<SampleProject> getSamples()
        {
            return this.SamplesList;
        }


    }
}