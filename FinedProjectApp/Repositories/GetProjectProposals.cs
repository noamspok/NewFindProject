using FinedProjectApp.Models.Users;
using System;
using System.Collections.Generic;
using System.Data;
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
					SqlDataAdapter d = new SqlDataAdapter("select ProjectName,ProjectPath from Projects a where a.@group > 1" +
						"and a.@field > 1 and a.ProjectName in (select ProjectName from ProjectLang b where b.@language)"
							+ "and a.ProjectName in(select ProjectName from ProjectKind c where c.@Kind) LIMIT 3",connection);
					d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@group", stud.GroupSize[0])
						.Replace("@language", stud.FavoriteLang[0])
						.Replace("@Kind", stud.KindOfProject[0]).Replace("@field", stud.FieldOfProject[0]);
					DataTable t = new DataTable();
					d.Fill(t);
					//לטפל במקרה ששאילתא לא מגיעה ל3 הצעות
					if (t.Rows.Count<3)
					{
						d.SelectCommand.CommandText = "select ProjectName,ProjectPath from Projects a where a.@group > 1" +
						"and a.@field > 1 and a.ProjectName in (select ProjectName from ProjectLang b where b.@language)"
							+ "and a.ProjectName in(select ProjectName from ProjectKind c where c.@Kind) LIMIT 3";
						d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@group", stud.GroupSize[0])
						.Replace("@language", stud.FavoriteLang[0])
						.Replace("@Kind", stud.KindOfProject[0]).Replace("@field", stud.FieldOfProject[0]);

					}

				}
				return null;
			}
			catch (Exception)
			{

				return null;
			}

		}

		private static string getlongest(StudentFinalRates stud)
		{
			int groupCount= stud.GroupSize.Count;
			int kindCount = stud.KindOfProject.Count;
			int fieldCount = stud.FieldOfProject.Count;
			int langCount = stud.FavoriteLang.Count;
			if (groupCount>kindCount)
			{
				if (groupCount>fieldCount)
				{
					if (groupCount>langCount)
					{
						return "group";
					}
					return "field";
				}
				if (fieldCount > langCount)
				{
					return "field";
				}
				return "lang";
			}
			if (kindCount > fieldCount)
			{
				if (kindCount > langCount)
				{
					return "kind";
				}
				return "lang";
			}
			if (fieldCount > langCount)
			{
				return "field";
			}
			return "lang";
		}
		
	}
}