using BenchmarkDotNet.Running;
using IntroToLinq;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Welcome To Linq Series");

		Console.WriteLine("------------Without Linq------------");
		BenchmarkRunner.Run<WithoutLinq>();

		Console.WriteLine("------------With Linq---------------");
		BenchmarkRunner.Run<WithLinq>();

	}
}

