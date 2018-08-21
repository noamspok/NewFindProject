using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinedProjectApp.Models.Users
{
    public class Director
    {
        //directors user name
        [Key]
        public string UserName { get; set; }
        //directors password
        [Required]
        public string Password { get; set; }
        //directors email
        [Required]
        public string Email { get; set; }
    }
}