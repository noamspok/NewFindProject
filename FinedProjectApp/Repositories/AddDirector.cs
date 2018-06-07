﻿using FinedProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
	public class AddDirector
	{
		private const string connectionString = @"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename = |DataDirectory|\Database1.mdf; Integrated Security = True";

		public static bool AddDirectors(ProjectDirec stud)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO Directors(UserName, Password, E_mail)" +
						" VALUES('@UserName', '@Password', '@E_mail') ";

					command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = stud.UserName;
					command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = stud.Password;
					command.Parameters.Add("@E_mail", SqlDbType.NVarChar).Value = stud.Email;
					var rowsAffected = command.ExecuteNonQuery();
					return rowsAffected == 1;
				}
			}
			catch (Exception)
			{

				return false;
			}

		}

		public static bool AddDirectorsCourses(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO DirectorsCourses(@cols) VALUES('@values') ";
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

		public static bool AddDirectorLang(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO ProjectLang(@cols) VALUES('@values') ";
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

		public static bool AddProject(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO Projects(@cols) VALUES('@values') ";
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

		public static bool AddDProjectKind(String cols, String values)
		{
			try
			{
				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					var command = connection.CreateCommand();
					command.CommandText = "INSERT INTO ProjectKind(@cols) VALUES('@values') ";
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