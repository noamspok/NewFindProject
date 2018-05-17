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
        public static bool AddStudentsPref(StudentPref studP)
        {

            var connectionstring = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\noamspok\Source\Repos\FinedProjectApp\FinedProjectApp\App_Data\Database1.mdf; Integrated Security = True";
            var query = "INSERT INTO StudentPref (UserName,FavoriteLang,Location,GroupSize,KindOfProject,FieldOfProject) VALUES ('@UserName','@FavoriteLang','@Location','@GroupSize','@KindOfProject','@FieldOfProject') ";
            query = query.Replace("@UserName", studP.UserName).Replace("@FavoriteLang", studP.FavoriteLang).
                Replace("@Location", studP.Location).Replace("@GroupSize", studP.GroupSize.ToString())
                .Replace("@KindOfProject", studP.KindOfProject).Replace("@FieldOfProject", studP.FieldOfProject);
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
   
   
