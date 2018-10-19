using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models.SampleProjects
{
    public class SurveyResult
    {
        //profile nickname.
        [Key]
        public string UserName { get; set; }


        [Required]
        public int Q1 { get; set; }
        public int Q2 { get; set; }
        public int Q3 { get; set; }
        public int Q4 { get; set; }
        public int Q5 { get; set; }
    }
}