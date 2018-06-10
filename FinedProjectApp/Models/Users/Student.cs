
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
         * student's personal details
         */
         //students profile nickname.
        [Key]
        public string UserName { get; set; }
        
        //student's password
        [Required]
        public string Password { get; set; }
        //student's id
        [Required]
        public int Id { get; set; }
        //student's email
        [Required]
        public string Email { get; set; }
        //student's first name
        [Required]
        public string FirstName { get; set; }
        //student's last name
        [Required]
        public string LastName { get; set; }
        //students gender: male/female
        
        /*
         * students professional information
         */
        
        //student degree average
        [Required]
        public int Average { get; set; }
        
        //student elective courses
        [Required]
        public string Courses { get; set; }
        //language studen knows.
        [Required]
        public string ProgrammingLanguage { get; set; }

        
    }
}