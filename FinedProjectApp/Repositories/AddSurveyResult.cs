using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinedProjectApp.Models.SampleProjects;

namespace FinedProjectApp.Repositories
{
    public class AddSurveyResult
    {
        private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

        public static bool update(SurveyResult survey)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO Survey(UserName, Q1, Q2,Q3, Q4, Q5)" +
                        " VALUES('@UserName', '@Q1', '@Q2', '@Q3', '@Q4', '@Q5') ";

                    command.CommandText = command.CommandText.Replace("@UserName", survey.UserName);
                    command.CommandText = command.CommandText.Replace("@Q1", survey.Q1.ToString());
                    command.CommandText = command.CommandText.Replace("@Q2", survey.Q2.ToString());
                    command.CommandText = command.CommandText.Replace("@Q3", survey.Q3.ToString());
                    command.CommandText = command.CommandText.Replace("@Q4", survey.Q4.ToString());
                    command.CommandText = command.CommandText.Replace("@Q5", survey.Q5.ToString());
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