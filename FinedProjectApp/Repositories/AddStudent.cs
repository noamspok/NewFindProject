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

		public static bool AddStudents(Student stud)
        {
            try
            {
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO Student(UserName, Password, E_mail, first_Name, Last_Name, Id,Avg)" +
						" VALUES('@UserName', N'@Password', '@E_mail', '@first_Name', '@Last_Name', '@Id', '@avg') ";
                    command.CommandText = command.CommandText.Replace("@UserName", stud.UserName).Replace("@Password", stud.Password)
                        .Replace("@E_mail", stud.Email).Replace("@first_Name", stud.FirstName).Replace("@Last_Name", stud.LastName)
                        .Replace("@Id", stud.Id.ToString()).Replace("@avg", stud.Average.ToString());
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
					command.CommandText = "INSERT INTO StudentCourses(@cols) VALUES(@values) ";
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
					command.CommandText = "INSERT INTO StudentsKnownLanguage(@cols) VALUES(@values) ";
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