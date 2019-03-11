using System;
using NUnit.Framework;
using NUnit.Framework.Internal;


namespace Calculator_UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(0, 5, 0.1, 50.0)]
        [TestCase(5, 0, 0.1, 50.0)]
        [TestCase(5, 5, 0.1, 70.7106)]
        [TestCase(5, 5, 2, 3.5355)]
        public void TestSpeedCorrectSpeed(int a, int b, double c, double result)
        {
            Assert.That(Calculator.SHCalculator.GetCurrentSpeed(a, b, c), Is.EqualTo(result).Within(4));
        }

        [TestCase(0, 0, 1, 0, 90.000)]
        [TestCase(0, 0, 0, -1, 180)]
        [TestCase(0, 0, 1, 0, 270)]
        public void TestHeadingCorrectHeading(int a1, int b1, int a2, int b2, double result)
        {
            
            Assert.That(Calculator.SHCalculator.GetCurrentHeading(a2 - a1, b2 - b1), Is.EqualTo(result).Within(3));
        }
    }
}
