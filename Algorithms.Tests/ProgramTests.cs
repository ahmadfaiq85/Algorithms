using NUnit.Framework;


namespace Algorithms.Tests
{
    class ProgramTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Factorial_Test()
        {
            int num = 4;
            var factorial = new Algorithms.Factorial();

            Assert.AreEqual(24, factorial.RecursiveFactorial(num));

        }

    }
}
