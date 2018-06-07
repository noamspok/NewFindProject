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
        public static bool SignIn(String username, String password)
        {

			try
			{
				using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "Select Password FROM Student WHERE UserName=@UserName ";
                command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;
                var dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    return (password==dataReader.GetString(0));
                }

                    return false ;
            }
			}
			catch (Exception)
			{

				return false;
			}



		}
    }
}