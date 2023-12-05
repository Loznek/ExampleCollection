
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleCollection.Examples;

namespace ExampleCollection.Tests
{
    [TestClass]
    public class IsPrimeTest
    {
        private readonly ExampleAlgorithms _exampleAlgorithms;

        public IsPrimeTest()
        {
            _exampleAlgorithms = new ExampleAlgorithms();
        }

        [TestMethod]
        public void IsPrime_LessThanTwo_ReturnsFalse()
        {
            Assert.IsFalse(_exampleAlgorithms.IsPrime(1));
            Assert.IsFalse(_exampleAlgorithms.IsPrime(0));
            Assert.IsFalse(_exampleAlgorithms.IsPrime(-1));
        }

        [TestMethod]
        public void IsPrime_Two_ReturnsTrue()
        {
            Assert.IsTrue(_exampleAlgorithms.IsPrime(2));
        }

        [TestMethod]
        public void IsPrime_PrimeNumbers_ReturnsTrue()
        {
            Assert.IsTrue(_exampleAlgorithms.IsPrime(3));
            Assert.IsTrue(_exampleAlgorithms.IsPrime(5));
            Assert.IsTrue(_exampleAlgorithms.IsPrime(7));
            Assert.IsTrue(_exampleAlgorithms.IsPrime(11));
            Assert.IsTrue(_exampleAlgorithms.IsPrime(13));
        }

        [TestMethod]
        public void IsPrime_NonPrimeNumbers_ReturnsFalse()
        {
            Assert.IsFalse(_exampleAlgorithms.IsPrime(4));
            Assert.IsFalse(_exampleAlgorithms.IsPrime(6));
            Assert.IsFalse(_exampleAlgorithms.IsPrime(8));
            Assert.IsFalse(_exampleAlgorithms.IsPrime(9));
            Assert.IsFalse(_exampleAlgorithms.IsPrime(10));
        }

        [TestMethod]
        public void IsPrime_LargePrimeNumber_ReturnsTrue()
        {
            Assert.IsTrue(_exampleAlgorithms.IsPrime(7919));
        }

        [TestMethod]
        public void IsPrime_LargeNonPrimeNumber_ReturnsFalse()
        {
            Assert.IsFalse(_exampleAlgorithms.IsPrime(7920));
        }
    }
}
