using NUnit.Framework;
using ExampleCoreLib2;

namespace ExampleCoreLib2Test
{
    public class ExampleClassTests
    {
        [Test]
        public void Multiply_ShouldReturnCorrectResult()
        {
            var example = new ExampleClass();
            Assert.AreEqual(6, example.Multiply(2, 3));
        }
    }
}
