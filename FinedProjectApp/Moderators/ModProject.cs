using FinedProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Moderators
{
    public class ModProject
    {
        public static bool SetProject(Project direcP)
        {
            return ModAddProject.AddProject(direcP);
        }
    }
}