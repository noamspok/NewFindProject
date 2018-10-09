using FinedProjectApp.Models.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
	public class GetProjectProposals
	{
		private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static List<String> GetProjects(StudentFinalRates stud)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "select ProjectName,ProjectPath from Projects a where a.@group > 1"+
						"and a.@field > 1 and a.ProjectName in (select ProjectName from ProjectLang b where b.@language)"
							+ "and a.ProjectName in(select ProjectName from ProjectKind c where c.@Kind) LIMIT 3";
					command.CommandText = command.CommandText.Replace("@group", stud.GroupSize[0])
						.Replace("@language", stud.FavoriteLang[0])
						.Replace("@Kind", stud.KindOfProject[0]).Replace("@field", stud.FieldOfProject[0]);
					var rowsAffected = command.ExecuteNonQuery();
					
				}
				return null;
			}
			catch (Exception)
			{

				return null;
			}

		}


		
	}
}