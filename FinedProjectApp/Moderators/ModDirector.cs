using FinedProjectApp.Models;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Moderators
{
	public class ModDirector
	{

		public static bool SetDirector(string userName, string password, string e_mail)
		{

			return AddDirector.AddDirectors(userName,password,e_mail);
				
				
		}
		public static bool SetProject(ProjectDirec direcP)
		{
			return ModAddProject.AddProject(direcP);
		}
	}
}