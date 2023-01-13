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
        public void fakultät_number_ReturnsCorrectNumber()
        {
            var fakultaet = new Fakultät();
            int fakultaet1 = fakultaet.FakultätCalc(6);
            int fakultaet2 = fakultaet.FakultätCalc(0);
            int fakultaet3 = fakultaet.FakultätCalc(-1);
            Assert.AreEqual(720, fakultaet1);
            Assert.AreEqual(0, fakultaet2);
            Assert.AreEqual(0, fakultaet3);
        }

        [Test]
        public void fibonacci_number_ReturnsCorrectFibonacciValue()
        {
            var fibonacci = new Fibonacci();
            int fibonacciCalc1 = fibonacci.FibonacciCall(5);
            int fibonacciCalc2 = fibonacci.FibonacciCall(-1);
            int fibonacciCalc3 = fibonacci.FibonacciCall(0);
            Assert.AreEqual(5, fibonacciCalc1);
            Assert.AreEqual(0, fibonacciCalc2);
            Assert.AreEqual(0, fibonacciCalc3);
        }
    }
}