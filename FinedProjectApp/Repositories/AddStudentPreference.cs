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
        public static bool AddStudentsPref(String Cols,String Values)
        {
        
            var connectionstring = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";
            var query = "INSERT INTO StudentPref ('@cols') VALUES ('@values') ";
            query = query.Replace("@cols",Cols).Replace("@values",Values);
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
   
   
