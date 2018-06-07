using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FinedProjectApp.Models;

namespace FinedProjectApp.Repositories
{
	

	public class AddStudentPreference
    {
		private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static bool AddStudentsPref(String Cols,String Values)
        {
        
            try
            {
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO StudentPref (@cols) VALUES (@values)";
					command.CommandText = command.CommandText.Replace("@cols", Cols).Replace("@values", Values);
					var rowsAffected = command.ExecuteNonQuery();
					return rowsAffected == 1;
				}
			}
            catch (Exception)
            {

                return false;
            }
 }
		public static bool AddStudentsPrefKind(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO StudentPrefKind(@cols) VALUES('@values') ";
					command.CommandText = command.CommandText.Replace("@cols", cols);
					command.CommandText = command.CommandText.Replace("@values", values);
					var rowsAffected = command.ExecuteNonQuery();
					return rowsAffected == 1;
				}
			}
			catch (Exception)
			{

				return false;
			}
		}

		public static bool AddStudentsPrefLang(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO StudentprefLanguage(@cols) VALUES('@values') ";
					command.CommandText = command.CommandText.Replace("@cols", cols);
					command.CommandText = command.CommandText.Replace("@values", values);
					var rowsAffected = command.ExecuteNonQuery();
					return rowsAffected == 1;
				}
			}
			catch (Exception)
			{

				return false;
			}


		}
	}
}
   
   
