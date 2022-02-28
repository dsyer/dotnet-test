using NUnit.Framework;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Threading.Tasks;

namespace Unit
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestAdd()
		{
			Assert.AreEqual(3, Hello.Program.Add(1, 2));
		}

		[Test]
		public async Task TestCreateScript()
		{
			var script = CSharpScript.Create("System.Console.WriteLine(\"Starting\"); 1 + 2");
			var state = await script.RunAsync();
			Assert.AreEqual(3, state.ReturnValue);
			System.Console.WriteLine("Done");
		}

	}
}