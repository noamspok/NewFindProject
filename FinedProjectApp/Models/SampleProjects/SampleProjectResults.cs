using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class SampleProjectResults
    {
        
      
        //profile nickname.
        [Key]
        public string UserName { get; set; }

      
        [Required]
        public int[] Results { get; set; }

        [Required]
        public string Kind { get; set; }


    }
}