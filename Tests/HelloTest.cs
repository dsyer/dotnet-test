using System;
using Xunit;

namespace Test
{
    public class HelloTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(3, Hello.Program.Add(1, 2));
        }
    }
}
