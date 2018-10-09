using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FinedProjectApp.Models.Users;

namespace FinedProjectApp.Repositories
{
	public class GetStudentFinalRates
	{
		private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static StudentFinalRates GetFinalRates(string uname)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();
					StudentFinalRates stud = new StudentFinalRates();
					SqlDataAdapter d = new SqlDataAdapter("select * from StudentPref where UserName = @userName", connection);
					d.SelectCommand.CommandText=d.SelectCommand.CommandText.Replace("@userName", uname);
					DataTable t = new DataTable();
					Dictionary <string, int> dic=new Dictionary<string, int>();
					d.Fill(t);
					int splen = t.Columns.Count;
					d.SelectCommand.CommandText = "select * from StudentsPrefKind where UserName = @userName";
					d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@userName", uname);
					d.Fill(t);
					int spklen = t.Columns.Count;
					d.SelectCommand.CommandText = "select * from StudentsPrefLanguage where UserName = @userName";
					d.SelectCommand.CommandText = d.SelectCommand.CommandText.Replace("@userName", uname);
					d.Fill(t);
					int row = 0;
					string s = t.Rows[0][0].ToString();
					for (int i=1;i< t.Columns.Count;i++)
					{
						if (i == splen)
							row = 1;
						if (i == spklen)
							row = 2;
						dic.Add(t.Columns[i].ColumnName, (int)t.Rows[row][i]);
					}

					stud = FinalStudPref.GetFinalRates(t.Rows[0][0].ToString(),dic, splen - 1, spklen - 1);
					return stud;
				}
			}
			catch (Exception)
			{

				return null;
			}
		}
	}
			
	}
