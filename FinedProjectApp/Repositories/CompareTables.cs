using FinedProjectApp.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
	public class CompareTables
	{
		private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static List<String> GetSim(string stud, string comp,string table)
		{
			
			Dictionary<string, int> dic = new Dictionary<string, int>();
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					string tab = table;
					if (table == "ProjectsG" || table == "ProjectsF")
						tab = "Projects";
					connection.Open();
					SqlDataAdapter d = new SqlDataAdapter("select * from @table where ProjectName = '@userName'", connection);
					d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@userName", comp).Replace("@table", tab);
					DataTable t = new DataTable();
					
					d.Fill(t);
					for (int i = 1; i < t.Columns.Count; i++)
					{
						
						dic.Add(t.Columns[i].ColumnName, (int)t.Rows[0][i]);
					}

				}
				return getShared(StringToList(stud,table), getChosenOnly(dic));
			}
			catch (Exception)
			{

				return null;
			}

		}

		public static List<String> CompDirecStud(string stud, string proj, string table)
		{

			Dictionary<string, int> studdic = new Dictionary<string, int>();
			Dictionary<string, int> projdic = new Dictionary<string, int>();
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();
					SqlDataAdapter d = new SqlDataAdapter("select DirectorsCourses.*, Projects.Average from projects "+
						"inner JOIN DirectorsCourses ON projects.ProjectName = '@projName' and DirectorsCourses.ProjectName = '@projName' "
						, connection);
					d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@projName", proj);
					DataTable t = new DataTable();
					d.Fill(t);
					for (int i = 1; i < t.Columns.Count; i++)
					{
						
						projdic.Add(t.Columns[i].ColumnName, (int)t.Rows[0][i]);
					}
					d.SelectCommand.CommandText = "select StudentCourses.*, Student.Average from projects " +
						"inner JOIN StudentCourses ON projects.UserName = '@userName' and StudentCourses.UserName = '@userName' ";
					d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@userName", stud);
					t.Clear();
					d.Fill(t);
					for (int i = 1; i < t.Columns.Count; i++)
					{

						studdic.Add(t.Columns[i].ColumnName, (int)t.Rows[0][i]);
					}
				}
				return null;
			}
			catch (Exception)
			{

				return null;
			}

		}
		private static List<string> StringToList(string stud, string table)
		{
			List<string> retval = null;
			switch (table)
				
			{
				case "ProjectLang":
					return GetStudentFinalRates.GetFinalRates(stud).FavoriteLang;

				case "ProjectKind":
					return GetStudentFinalRates.GetFinalRates(stud).KindOfProject;

				case "ProjectsG":
					return GetStudentFinalRates.GetFinalRates(stud).GroupSize;

				case "ProjectsF":
					return GetStudentFinalRates.GetFinalRates(stud).FavoriteLang;
				default:
					break;
			}

			return retval;
		}
		private static List<string> getShared(List<string> stud, List<string> proj)
		{
			List<string> retval = new List<string>();
			for (int i = 0; i < stud.Count; i++)
			{
				if (proj.Contains(stud[i]))
					retval.Add(stud[i]);
			}
		
			return retval;

		}

		private static List<string> getChosenOnly(Dictionary<string, int> dic)
		{
			List<string> retval = new List<string>();
			dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
			int stop=0;
			for (int i = 0; i < dic.Count; i++)
			{
				if(!(dic.ElementAt(i).Value > 0))
				{
					stop = i;
					break;
				}
			}
			for (int i = 0; i < stop; i++)
			{
				retval.Add(dic.ElementAt(i).Key);
			}
			
			return retval;
		}

	}
}