using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinedProjectApp.Models
{
    public class StudentPref
    {
        
        //student's profile nickname.
        [Key]
        public string UserName { get; set; }
        
        //student preference in fild of project: industry/ reserch 
        [Required]
        public string FieldOfProject { get; set; }       
        //student preference in field of project: AI,machine learning etc..
        [Required] 
        public string KindOfProject { get; set; }

        //student preference in size of group to do the project with
        [Required]
        public string GroupSize { get; set; }

        //student preference of location:  University/outside 
        [Required]
        public string Location { get; set; }
        //student preference of location:  University/outside 
        [Required]
        public string FavoriteLang { get; set; }
    }
}