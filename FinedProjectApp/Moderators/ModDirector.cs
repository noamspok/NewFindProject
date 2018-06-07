using FinedProjectApp.Models;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Moderators
{
	public class ModDirector
	{

		public static bool SetDirector(ProjectDirec direcP)
		{
			ParseDirector(direcP);
			string coursescols = "ProjectName," + direcP.Courses;
			string courseval = direcP.ProjectName + (SetValueString(direcP.Courses));
			string Langscols = "ProjectName," + direcP.ProgrammingLanguage;
			string langval = direcP.ProjectName + (SetValueString(direcP.ProgrammingLanguage));
			string kindscols = "ProjectName," + direcP.KindOfProject;
			string kindval = direcP.ProjectName + (SetValueString(direcP.KindOfProject));
			string projcol = "ProjectName, ProjectPath,";
			string temp = "DirectorName, " + direcP.Location + "," + direcP.FieldOfProject + "," + direcP.GroupSize;
			projcol += temp;
			string projvalue = direcP.ProjectName + direcP.ProjectDescriptionFile + direcP.UserName + SetValueString(temp);
			return (AddDirector.AddDirectors(direcP)
				&& AddDirector.AddDirectorsCourses(coursescols, courseval)
				&& AddDirector.AddDirectorLang(Langscols, langval)
				&& AddDirector.AddProject(projcol, projvalue)
				&& AddDirector.AddDProjectKind(kindscols, kindval)
				);
		}

		private static String Parser(String s)
		{
			return s.Replace("\"", "").Replace("[", "").Replace("]", "");
		}


		private static String SetValueString(String var)
		{
			string ones = "";
			for (int i = 0; i < var.Length; i++)
			{
				if (var[i] == ',')
					ones += ",1";
			}

			return ones;

		}
		private static void ParseDirector(ProjectDirec direc)
		{
			direc.ProgrammingLanguage = Parser(direc.ProgrammingLanguage);
			direc.Location = Parser(direc.Location);
			direc.Courses = Parser(direc.Courses);
			direc.KindOfProject = Parser(direc.KindOfProject);
			direc.FieldOfProject = direc.FieldOfProject.Replace("תעשיה", "Industry").
				Replace("מחקר", "Research").Replace("לא משנה", "Industry,Research");
			direc.GroupSize = direc.GroupSize.Replace("4", "GroupSize_4").Replace("3", "GroupSize_3")
				.Replace("2", "GroupSize_2").Replace("1", "GroupSize_1")
				.Replace("לא משנה", "GroupSize_4,GroupSize_3,GroupSize_2,GroupSize_1");

		}
		
	}
}