using System;
using NUnit.Framework;
using ExampleCoreLib2;

namespace ExampleCoreLib2Test
{
    [TestFixture]
    public class MathOperationsTests
    {
        [Test]
        public void Multiply_ShouldReturnCorrectResult()
        {
            var mathOps = new MathOperations();
            int result = mathOps.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Add_ShouldReturnCorrectResult()
        {
            var mathOps = new MathOperations();
            int result = mathOps.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_ShouldReturnCorrectResult()
        {
            var mathOps = new MathOperations();
            int result = mathOps.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Divide_ShouldReturnCorrectResult()
        {
            var mathOps = new MathOperations();
            int result = mathOps.Divide(6, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            var mathOps = new MathOperations();
            Assert.Throws<DivideByZeroException>(() => mathOps.Divide(6, 0));
        }
    }
}
