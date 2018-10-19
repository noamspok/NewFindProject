using FinedProjectApp.Models.SampleProjects;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Moderators
{
    public class ModSurvey
    {
        public static bool UpdateTables(SurveyResult results)
        {
            if (!AddSurveyResult.update(results))
                return false;
            return true;
        }
        
    }

}