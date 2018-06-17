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

		public static bool SetDirector(ProjectDirec direcP)
		{

			return (AddDirector.AddDirectors(direcP)
				&& ModAddProject.AddProject(direcP)
				);
		}
	}
}