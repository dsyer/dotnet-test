using NUnit.Framework;

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
    }
}