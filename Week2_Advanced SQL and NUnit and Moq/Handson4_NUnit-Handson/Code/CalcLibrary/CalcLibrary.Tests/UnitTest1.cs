using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator.AllClear();
        }

        [TestCase(5, 3, 8)]
        [TestCase(-2, -3, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(1.5, 2.5, 4)]
        public void Addition_WhenCalled_ReturnsCorrectResult(double a, double b, double expected)
        {
            double actual = calculator.Addition(a, b);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }

        [TestCase(5, 3, 2)]
        [TestCase(-2, -3, 1)]
        [TestCase(0, 0, 0)]
        [TestCase(2.5, 1.2, 1.3)]
        public void Subtraction_WhenCalled_ReturnsCorrectResult(double a, double b, double expected)
        {
            double actual = calculator.Subtraction(a, b);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }

        [TestCase(5, 3, 15)]
        [TestCase(-2, -3, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(2.5, 2, 5)]
        public void Multiplication_WhenCalled_ReturnsCorrectResult(double a, double b, double expected)
        {
            double actual = calculator.Multiplication(a, b);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }

        [TestCase(6, 3, 2)]
        [TestCase(-9, -3, 3)]
        [TestCase(5, 2, 2.5)]
        public void Division_WhenCalled_ReturnsCorrectResult(double a, double b, double expected)
        {
            double actual = calculator.Division(a, b);
            Assert.That(actual, Is.EqualTo(expected).Within(0.0001));
        }

        [Test]
        public void Division_ByZero_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => calculator.Division(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));
        }
    }
}
