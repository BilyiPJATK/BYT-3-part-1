    namespace Part2_Calculator.tests;

    using NUnit.Framework;
    using System;
    using Part2_Calculator.program;

    public class CalculatorTests
        {
            [Test]
            public void TestAddition()
            {
                var calc = new Calculator(5, 3, '+');
                Assert.That(calc.Calculate(), Is.EqualTo(8));
            }

            [Test]
            public void TestSubtraction()
            {
                var calc = new Calculator(10, 4, '-');
                Assert.That(calc.Calculate(), Is.EqualTo(6));
            }

            [Test]
            public void TestMultiplication()
            {
                var calc = new Calculator(7, 6, '*');
                Assert.That(calc.Calculate(), Is.EqualTo(42));
            }

            [Test]
            public void TestDivision()
            {
                var calc = new Calculator(20, 4, '/');
                Assert.That(calc.Calculate(), Is.EqualTo(5));
            }

            [Test]
            public void TestDivisionByZeroThrowsException()
            {
                var calc = new Calculator(10, 0, '/');
                Assert.Throws<DivideByZeroException>(() => calc.Calculate());
            }

            [Test]
            public void TestInvalidOperationThrowsException()
            {
                var calc = new Calculator(10, 5, '%');
                Assert.Throws<InvalidOperationException>(() => calc.Calculate());
            }

            [Test]
            public void TestNegativeNumbers()
            {
                var calc = new Calculator(-8, -2, '*');
                Assert.That(calc.Calculate(), Is.EqualTo(16));
            }

            [Test]
            public void TestFloatingPointDivision()
            {
                var calc = new Calculator(7, 2, '/');
                Assert.That(calc.Calculate(), Is.EqualTo(3.5).Within(0.0001));
            }

            [Test]
            public void TestLargeNumbers()
            {
                var calc = new Calculator(1e6, 1e6, '+');
                Assert.That(calc.Calculate(), Is.EqualTo(2e6));
            }
        }

