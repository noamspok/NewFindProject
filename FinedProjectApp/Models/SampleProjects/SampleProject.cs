using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models
{
    public class SampleProject
    {
        private string kind;
		private List<string> languages;
		private List<string> fields;
		private int groupSize;
        private string file;

        public SampleProject(string kind, List<string> languages,  List<string> fields, int groupSize, string file)
        {
            this.kind = kind;
            this.languages = languages;
            this.fields = fields;
            this.groupSize = groupSize;
            this.file = file;
        }
        public string Kined { get; }
        public List<string> Languages { get; }
        public List<string> Fields { get; }
        public int GroupSize { get; }

        /*public List<string> GetMembers()
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
            return this.members;
		}*/
    }
}