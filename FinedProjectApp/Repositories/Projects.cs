using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
    public class Projects
    {
        private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

        public static List<string> getProjectsNames(string directorsName){
            List<string> listOfProjects = new List<string>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT ProjectName FROM Projects WHERE DirectorName = '@directorsName'";
                    command.CommandText = command.CommandText.Replace("@directorsName", directorsName);
                    var reader = command.ExecuteReader();
                    while (reader.Read())

                    {
                        listOfProjects.Add(reader["ProjectName"].ToString());

                    }
                    return listOfProjects;
                }
            }
            catch (Exception)
            {

                return null;
            }
            
    }
            
    }
}