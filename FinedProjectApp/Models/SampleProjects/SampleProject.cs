using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class SampleProject
    {

		private string languages;
		private string kind;
		private string groupSize;
		private string location;
		private string field;
		private List<string> members;
		public SampleProject(string lang, string kin, string groupSiz, string locatio, string fiel, string course)
		{
			members = new List<string>();
			languages = "languages,"+ lang;
			kind = "kind," + kin;
			groupSize = "pref," + groupSiz;
			location = "pref," + locatio;
			field = "pref," + fiel;
			members.Add(groupSize);
			members.Add(location);
			members.Add(field);
			members.Add(languages);
			members.Add(kind);
		}
		public List<string> GetMembers()
		{
			return this.members;
		}
		
		
    }
}