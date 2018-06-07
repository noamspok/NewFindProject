using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FinedProjectApp.Models;
using System.Data;

namespace FinedProjectApp.Repositories
{
    public class AddStudent
    {
		private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static bool AddStudents(Student stud )
        {
            try
            {
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO Student(UserName, Password, E_mail, first_Name, Last_Name, Id,Avg)" +
						" VALUES('@UserName', '@Password', '@E_mail', '@first_Name', '@Last_Name', '@Id','@avg') ";

					command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = stud.UserName;
					command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = stud.Password;
					command.Parameters.Add("@E_mail", SqlDbType.NVarChar).Value = stud.Email;
					command.Parameters.Add("@first_Name", SqlDbType.NVarChar).Value = stud.FirstName;
					command.Parameters.Add("@Last_Name", SqlDbType.NVarChar).Value = stud.LastName;
					command.Parameters.Add("@Id", SqlDbType.Int).Value = stud.Id;
					command.Parameters.Add("@avg", SqlDbType.Int).Value = stud.Average;
					var rowsAffected = command.ExecuteNonQuery();
					return rowsAffected == 1;
				}
			}
            catch (Exception)
            {

                return false;
            }

        }

		public static bool AddStudentsCourses(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO StudentCourses(@cols) VALUES('@values') ";
					command.CommandText = command.CommandText.Replace("@cols",cols);
					command.CommandText = command.CommandText.Replace("@values",values);
					var rowsAffected = command.ExecuteNonQuery();
					return rowsAffected == 1;
				}
			}
			catch (Exception)
			{

				return false;
			}
		}

		public static bool AddStudentsKnownLang(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO StudentKnownLanguage(@cols) VALUES('@values') ";
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