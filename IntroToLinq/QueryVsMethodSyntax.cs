using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLinq
{
	public class QueryVsMethodSyntax
	{
		public void Demo()
		{
			string[] names = { "Muhammad Ali", "Shafqat Ali", "Abdul Samad", "Muhammad Zain" };

			//Query Syntax 
			var queryRes1 = (from n in names
							 select n).ToList();

			//Method Syntax
			var methodRes1 = names.Select(t => t).ToList();

			//Query Syntax
			var queryRes2 = (from n in names
							 where n.Contains("Muhammad")
							 select n).ToList();

			//Method Syntax
			var methodRes2 = names.Where(t => t.Contains("Ali")).Select(t => t).ToList();

		}

	}
}
