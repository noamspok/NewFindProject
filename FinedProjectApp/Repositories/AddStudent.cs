using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using FinedProjectApp.Models;

namespace FinedProjectApp.Repositories
{
    public class AddStudent
    {
        public static bool AddStudents(Student stud )
        {
            
            var connectionstring = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\noamspok\Source\Repos\FinedProjectApp\FinedProjectApp\App_Data\Database1.mdf; Integrated Security = True";
            var query = "INSERT INTO Student (UserName,Password,E_mail,first_Name,Last_Name,Id) VALUES ('@UserName','@Password','@E_mail','@first_Name','@Last_Name','@Id') ";
            query= query.Replace("@UserName",stud.UserName).Replace("@Password",stud.Password).
                Replace("@E_mail",stud.Email).Replace("@first_Name",stud.FirstName)
                .Replace("@Last_Name",stud.LastName).Replace("@Id", stud.Id.ToString());
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