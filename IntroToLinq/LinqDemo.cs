using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLinq
{
	public class LinqDemo
	{
		public void Demo()
		{
			List<int> numbers = new List<int> {1,2,3,4,5 };
			numbers.Add(6);
			numbers.Select(x => x).ToList();
			numbers.Remove(3);
			numbers.Where(t => t >2).Select(t => t).ToList();
		}
	}
}
