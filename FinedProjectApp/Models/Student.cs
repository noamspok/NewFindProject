using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class Student
    {
        /*
         * students personal details
         */
        //students id
        public int Id { get; set; }
        //students first name
        [Required]
        public string FirstName { get; set; }
        //students last name
        [Required]
        public string LastName { get; set; }
        //students gender: male/female
        [Required]
        public string Gender { get; set; }
        //students age???????
        [Required]
        public string Age { get; set; }
        //or to put the birthday????
        public DateTime BirthDate { get; set; }
        /*
         * students professional information
         */
        
        //student degree average
        [Required]
        public int Average { get; set; }
        //students grup size
        [Required]
        public int GroupSize { get; set; }
        //student elective courses
        [Required]
        public string Courses { get; set; }
        //Locations where student is available for meating.
        [Required]
        public string Location { get; set; }
        //student preference in fild of project: industry/ reserch 
        [Required]
        public string FildOfProject { get; set; }
        //days where student is free for working on project.
        [Required]
        public string FreeDays { get; set; }
        //students degree mayjer and secondary
        [Required]
        public string Degree { get; set; }
        //amount of years of experience
        [Required]
        public int Experience { get; set; }
        //programming languages that student is familiar whith
        [Required]
        public string ProgrammingLanguage { get; set; }
        
    }
}