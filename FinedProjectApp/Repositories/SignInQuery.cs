using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
    public class SignInQuery
    {
        private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";
        public static string SignIn(String username, String password)
        {

			try
			{
				using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "Select Password FROM Student WHERE UserName = '@UserName'";
				command.CommandText = command.CommandText.Replace("@UserName", username);
                var dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
						if (password == dataReader.GetString(0))
							return "ok";
						return "wrong password";
							
                }

                    return "wrong username";
            }
			}
			catch (Exception)
			{
				return "exception";
				
			}



		}
		public static string DirectorSignIn(String username, String password)
		{

			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "Select Password FROM Directors WHERE UserName=@UserName ";
					command.CommandText = command.CommandText.Replace("@UserName", username);
					var dataReader = command.ExecuteReader();

					if (dataReader.Read())
					{
						if (password == dataReader.GetString(0))
							return "ok";
						return "wrong password";

					}

					return "wrong username";
				}
			}
			catch (Exception)
			{
				return "exception";

			}



		}
	}
}