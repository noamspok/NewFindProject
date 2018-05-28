using FinedProjectApp.Models;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace FinedProjectApp.Moderators
{
    public class ModStudentPref
    {
       private static String Parser(String s)
        {
            return s.Replace("\"", "").Replace("[", "").Replace("]", "");
        }

        

        private static void SetStudent(StudentPref stud )
        {
            stud.FavoriteLang= Parser(stud.FavoriteLang);
            stud.Location = Parser(stud.Location);
            stud.KindOfProject= Parser(stud.KindOfProject);
            stud.FieldOfProject = stud.FieldOfProject.Replace("תעשיה", "Industry").Replace("מחקר", "Research").Replace("לא משנה", "Industry,Research");
            stud.GroupSize = stud.GroupSize.Replace("4", "GroupSize_4").Replace("3", "GroupSize_3").Replace("2", "GroupSize_2").Replace("1", "GroupSize_1")
                .Replace("לא משנה", "GroupSize_4,GroupSize_3,GroupSize_2,GroupSize_1");
        }
       public static bool SetStudentPref(StudentPref studP)
        {
            SetStudent(studP);
            String pref="UserName,'@g','@L','@K','@FL','@F'";
            pref.Replace("@g", studP.GroupSize);//.Replace("@K", studP.KindOfProject).Replace("@L", studP.Location).Replace("@FL", studP.FavoriteLang).Replace("@F", studP.FieldOfProject);
            string fives="";
            for (int i = 0; i < pref.Length; i++)
            {
                if (pref[i] == ',')
                    fives += ",5";
            }
            String values=studP.UserName+"'@5'";
            values.Replace("@5", fives);
            

            return AddStudentPreference.AddStudentsPref(pref,values);
        }

    }
}