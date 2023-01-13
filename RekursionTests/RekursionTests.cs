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
        public void fakult�t_number_ReturnsCorrectNumber()
        {
            var fakultaet = new Fakult�t();
            int fakultaet1 = fakultaet.Fakult�tCalc(6);
            int fakultaet2 = fakultaet.Fakult�tCalc(0);
            int fakultaet3 = fakultaet.Fakult�tCalc(-1);
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