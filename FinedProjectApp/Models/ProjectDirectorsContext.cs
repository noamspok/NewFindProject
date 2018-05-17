﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class ProjectDirectorsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjectDirectorsContext() : base("name=ProjectDirectorsContext")
        {
        }

        public System.Data.Entity.DbSet<ProjectDirec> ProjectDirecs { get; set; }

        public System.Data.Entity.DbSet<FinedProjectApp.Models.StudentPref> StudentPrefs { get; set; }
    }
}
