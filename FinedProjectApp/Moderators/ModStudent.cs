using FinedProjectApp.Models;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Moderators
{
	public class ModStudent
	{
		private static String Parser(String s)
		{

			return s.Replace("\"", "").Replace("[", "").Replace("]", "");
		}


		private static String SetValueString(String var)
		{
			string ones="";
			for (int i = 0; i < var.Length; i++)
			{
				if (var[i] == ',')
					ones += ",'1'";
			}
			
			return ones;

		}
		private static void ParseStudent(Student stud)
		{
			stud.Courses = Parser(stud.Courses);
			stud.ProgrammingLanguage = Parser(stud.ProgrammingLanguage);
			
		}
		public static bool SetStudent(Student studP, string pass)
		{
			ParseStudent(studP);
            studP.Password = pass;
			string coursescols = "UserName, " + studP.Courses;
			string courseval = "'" + studP.UserName + "'" + (SetValueString(coursescols));
			string Langscols = "UserName, " + studP.ProgrammingLanguage;
			string langval = "'" + studP.UserName + "'" + (SetValueString(Langscols));
			String values = studP.UserName;
			return (AddStudent.AddStudents(studP)
				&& AddStudent.AddStudentsCourses(coursescols,courseval) 
				&& AddStudent.AddStudentsKnownLang(Langscols,langval)
				);
		}
	}
}