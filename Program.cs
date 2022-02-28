using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;
using System;

namespace Hello
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var state = await CSharpScript.RunAsync("using System; Console.WriteLine(\"Starting\"); 1 + 2");
			Console.WriteLine("Done: " + state.ReturnValue);
		}
		public static int Add(int one, int two) => (one + two);

	}
}
