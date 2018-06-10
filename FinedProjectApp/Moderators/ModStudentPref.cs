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
       
       public static bool SetStudentPref(StudentPref studP)
        {
			ParseStudentPref(studP);
            String pref="UserName,";
            pref+=studP.GroupSize+','+ studP.Location+',' + studP.FieldOfProject;
			String values = studP.UserName + SetValueString(pref);
			string kindcols = "UserName," + studP.KindOfProject;
			String kindvalues = studP.UserName + SetValueString(kindcols);
			string langcols = "UserName," + studP.FavoriteLang;
			String langvalues = studP.UserName + SetValueString(langcols);
			return (AddStudentPreference.AddStudentsPref(pref,values)
				&& AddStudentPreference.AddStudentsPrefKind(kindcols,kindvalues)
				&& AddStudentPreference.AddStudentsPrefLang(langcols,langvalues)
				);
        }

		private static String Parser(String s)
		{
			return s.Replace("\"", "").Replace("[", "").Replace("]", "");
		}



		private static void ParseStudentPref(StudentPref stud)
		{
			stud.FavoriteLang = Parser(stud.FavoriteLang);
			stud.Location = Parser(stud.Location);
			stud.KindOfProject = Parser(stud.KindOfProject);
			stud.FieldOfProject = stud.FieldOfProject.Replace("תעשיה", "Industry").Replace("מחקר", "Research").Replace("לא משנה", "Industry,Research");
			stud.GroupSize = stud.GroupSize.Replace("4", "GroupSize_4").Replace("3", "GroupSize_3").Replace("2", "GroupSize_2").Replace("1", "GroupSize_1")
				.Replace("לא משנה", "GroupSize_4,GroupSize_3,GroupSize_2,GroupSize_1");
		}

		private static String SetValueString(String var)
		{
			string fives = "";
			for (int i = 0; i < var.Length; i++)
			{
				if (var[i] == ',')
					fives += ",5";
			}

			return fives;

		}

	}
}