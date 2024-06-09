using BenchmarkDotNet.Attributes;
using IntroToLinq.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IntroToLinq
{
	public class WithoutLinq
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

			// Traditional approach
			List<Person> result = new List<Person>();
			foreach (var person in people)
			{
				if (person.Age > 30)
				{
					result.Add(person);
				}
			}

			result.Sort((x, y) => x.Name.CompareTo(y.Name));


		}
	}
}
