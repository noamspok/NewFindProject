using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Models.Users
{
	public class StudentFinalRates
	{


		
	
		public string UserName { get; set; }

		
		public List<string> FieldOfProject { get; set; }
		
		
		public List<string> KindOfProject { get; set; }

		
		public List<string> GroupSize { get; set; }


		public List<string> FavoriteLang { get; set; }

		public StudentFinalRates(string Uname, List<string> field, List<string> kind, List<string> group, List<string> fav)
		{
			this.FavoriteLang = fav;
			this.GroupSize = group;
			this.KindOfProject = kind;
			this.UserName = Uname;
			this.FieldOfProject = field;
		}

		public StudentFinalRates()
		{
		}
	}
}