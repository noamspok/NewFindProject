using FinedProjectApp.Models;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace FinedProjectApp.Moderators
{
    public static class ModProject
    {
        public static bool UpdateTables(ISampleProjects samples, SampleProjectResults results)
        {
            int i = 0;
            foreach (SampleProject sample in samples.Samples)
            {
                
                foreach (PropertyInfo property in sample.GetType().GetProperties())
                {
                    
                        foreach (var loc in Parser(property))
                        {
                            if (!UpdateFromProjectSamp.UpdateKind(results.UserName, loc, results.Results[i], "Projects"))
                                return false;
                        }
                        
                    }
                
                i++;
            }
            return true;
        }

        private static bool Update(string user, SampleProject project, int result)
        {
            foreach (var loc in Parser(project.Location))
            {
                if (!UpdateFromProjectSamp.UpdateKind(user, loc, result, "Projects"))
                    return false;
            }
            return true;
        }

       private static string NametoTable(string s)
        {
            switch (s)
            {
                case "languages":

                    return "languages";
                default: return "";
            }
        }

        private static string[] Parser(object s)
        {

            return( (s as string).Split(','));
        }
    }
}