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
            SamplesList.Add(new SampleProject("research", new List<string>(new string[] { "ML", "AI", "Web" }), new List<string>(new string[] { "JS", "Java" }), 3, "need fiel to display"));
            SamplesList.Add(new SampleProject("research", new List<string>(new string[] { "Cyber" }), new List<string>(new string[] { "C" }), 1, "need fiel to display"));
            SamplesList.Add(new SampleProject("research", new List<string>(new string[] { "aplication" }), new List<string>(new string[] { "angular", "Swift" }), 2, "need fiel to display"));
            SamplesList.Add(new SampleProject("research", new List<string>(new string[] { "AI", "Web" }), new List<string>(new string[] { "JS", "C#", "sql" }), 2, "need fiel to display"));
            SamplesList.Add(new SampleProject("research", new List<string>(new string[] { "Cyber", "Web" }), new List<string>(new string[] { "JS", "python" }), 1, "need fiel to display"));
            SamplesList.Add(new SampleProject("industry", new List<string>(new string[] { "aplication" }), new List<string>(new string[] { "angular", "sql" }), 2, "need fiel to display"));
            SamplesList.Add(new SampleProject("industry", new List<string>(new string[] { "Web", "AI" }), new List<string>(new string[] { "JS", "C#", "sql" }), 2, "need fiel to display"));
            SamplesList.Add(new SampleProject("industry", new List<string>(new string[] { "aplication" }), new List<string>(new string[] { "Swift", "angular" }), 1, "need fiel to display"));
            SamplesList.Add(new SampleProject("industry", new List<string>(new string[] { "aplication" }), new List<string>(new string[] { "Swift", "angular" }), 2, "need fiel to display"));
            SamplesList.Add(new SampleProject("industry", new List<string>(new string[] { "ML"}), new List<string>(new string[] { "python", "JS" }), 4, "need fiel to display"));

        }
        public List<SampleProject> getSamples()
        {
            return this.SamplesList;
        }


    }
}