using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
    public class UpdateKindOfProj
    {
        private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static bool UpdateKind(String username, String kind, int add)
        {

			try
			{
				using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "Select @kind FROM StudenrsPrefKind WHERE UserName=@UserName ";
                command.CommandText.Replace("@kind",kind);
                var dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    add += dataReader.GetInt16(0);
                }
                String newValue = add.ToString();
                command.CommandText = "UPDATE INTO StudenrsPrefKind set @kind = '@value' WHERE UserName=@UserName";
                command.CommandText.Replace("@UserName", username);
                command.CommandText.Replace("@kind", kind);
                command.CommandText.Replace("@value",newValue);
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