﻿using System;
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
		private string field;
		private List<string> members;
		public SampleProject(string fiel, string kin, string lang,  string groupSiz)
		{
			members = new List<string>();
			languages = "languages," + lang;
			kind = "kind," + kin;
			groupSize = "pref," + groupSiz;
			field = "pref," + fiel;
			members.Add(groupSize);
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