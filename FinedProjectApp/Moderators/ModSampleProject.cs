using FinedProjectApp.Models;
using FinedProjectApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace FinedProjectApp.Moderators
{
	public static class ModSampleProject
	{
		public static bool UpdateTables(ISampleProjects samples, SampleProjectResults results)
		{
			int j = 0;
			foreach (SampleProject sample in samples.SamplesList)
			{

				foreach (string s in sample.GetMembers())
				{
					List<string> temp = Parser(s);

					for (int i = 1; i < temp.Count; i++)
					{
						if (!UpdateFromProjectSamp.UpdateKind(results.UserName, temp[i], results.Results[j], NametoTable(temp[0])))
							return false;
					}

				}

				j++;
			}
			return true;
		}



		private static string NametoTable(string s)
		{
			switch (s)
			{
				case "languages":

					return "StudentsPrefLanguage";

				case "kind":

					return "StudentsPrefKind";


				default:
					return "StudentsPref";
			}
		}

		private static List<string> Parser(string s)
		{
			List<string> temp = new List<string>();
			;
			foreach (var str in s.Split(','))
			{
				temp.Add(str);
			}
			return temp;
		}
	}
}