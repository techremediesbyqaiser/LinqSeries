using BenchmarkDotNet.Attributes;
using IntroToLinq.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLinq
{
	public class WithLinq
	{
		[Benchmark]
		public void Demo()
		{
			List<Person> people = new List<Person>
			{
				new Person { Name = "John", Age = 25 },
				new Person { Name = "Jane", Age = 34 },
				new Person { Name = "Bill", Age = 29 },
				new Person { Name = "Anna", Age = 42 }
			};

			// Using LINQ
			var result = from person in people
						 where person.Age > 30
						 orderby person.Name
						 select person;


		}
	}
}
