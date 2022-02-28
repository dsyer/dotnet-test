using NUnit.Framework;
using Microsoft.CodeAnalysis.CSharp.Scripting;

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
		public void TestCreateScript()
		{
			var script = CSharpScript.Create("1 + 2");
			Assert.AreEqual("1 + 2", script.Code);
		}

	}
}