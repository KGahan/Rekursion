using NUnit.Framework;
using Rekursion;

namespace RekursionTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void idkwhattosay()
        {
            var fakultaet = new Fakult�t();
            int fakultaetCalc = fakultaet.Fakult�tt(6);
            Assert.AreEqual(720, fakultaetCalc);
        }

        [Test]
        public void idkwhattosay2()
        {
            var fibonacci = new Fibonacci();
            int fibonacciCalc = fibonacci.Fibonaccii(5);
            Assert.AreEqual(5, fibonacciCalc);
        }
    }
}