using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class SampleProject
    {

        

        public SampleProject(string languages, string kind, string groupSize, string location, string field, string courses)
        {
            Languages = languages;
            Kind = kind;
            GroupSize = groupSize;
            Location = location;
            Field = field;
            Courses = courses;
        }

        public string Languages { get; set; }
        public string Kind { get; set; }
        public string GroupSize { get; set; }
        public string Location { get; set; }
        public string Field { get; set; }
        public string Courses { get; set; }
    }
}