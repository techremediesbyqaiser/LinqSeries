using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace IntroToLinq
{
	public class LINQProsNCons
	{
		public void DeferredExecution()
		{
			// Create a list of numbers
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

			// Define a LINQ query with deferred execution
			var query = numbers.Where(n => n > 2);

			// At this point, the query is defined but not executed

			// Modify the original list
			numbers.Add(6);
			numbers.Add(7);

			var res = numbers.ToList();
		}
	}
}
