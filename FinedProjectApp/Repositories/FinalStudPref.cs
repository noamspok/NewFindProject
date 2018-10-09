using FinedProjectApp.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinedProjectApp.Repositories
{
	public class FinalStudPref
	{
		public static StudentFinalRates GetFinalRates(string uname, Dictionary<string, int> dic, int kindAmount, int langAmount)
		{
			StudentFinalRates retval = new StudentFinalRates();
			retval.UserName = uname;
			retval.FavoriteLang = getMax3(getSpecDic(dic, langAmount, dic.Count));
			retval.KindOfProject = getMax3(getSpecDic(dic, kindAmount,langAmount));
			retval.GroupSize = getGroup(dic);
			retval.FieldOfProject = getfield(dic);

			return retval;
		}

		private static List<string> getGroup(Dictionary<string, int> dic)
		{
			List<string> temp = getMax3(getSpecDic(dic, 2, 6));
			List<string> retval = new List<string>();
			retval.Add(temp[0]);
			if (temp.Count> 1)
				retval.Add(temp[1]);
			return retval;
		}
		private static List<string> getfield(Dictionary<string, int> dic)
		{
			
			List<string> retval = new List<string>();
			if (dic.ElementAt(0).Value > dic.ElementAt(1).Value)
			{
				retval.Add(dic.ElementAt(0).Key);
			}
			else if (dic.ElementAt(1).Value > dic.ElementAt(0).Value)
			{
				retval.Add(dic.ElementAt(1).Key);
			}
			else
			{
				retval.Add(dic.ElementAt(1).Key);
				retval.Add(dic.ElementAt(0).Key);
			}
			return retval;
		}




		private static List<string> getMax3(Dictionary<string, int> dic) {
			List<string> retval = new List<string>();
			dic = dic.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); 
			retval.Add(dic.ElementAt(0).Key);
			if (dic.ElementAt(1).Value > 0) { 
			retval.Add(dic.ElementAt(1).Key);
				if (dic.ElementAt(2).Value > 0)
					retval.Add(dic.ElementAt(2).Key);
			}
			return retval;
		}

		private static Dictionary<string, int> getSpecDic(Dictionary<string, int> dic, int i, int j)
		{
			Dictionary<string, int> temp = new Dictionary<string, int>();
			for (int k = i; k < j; k++)
			{
				temp.Add(dic.ElementAt(k).Key, dic.ElementAt(k).Value);
			}
			return temp;
		}
	}
}