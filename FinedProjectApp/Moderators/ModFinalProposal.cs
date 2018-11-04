using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinedProjectApp.Repositories;

namespace FinedProjectApp.Moderators
{
	public class ModFinalProposal
	{
		public static List<string> GetFinalProjects(string user)
		{
			return GetProjectProposals.GetProjects(GetStudentFinalRates.GetFinalRates(user));
		}
	}
}