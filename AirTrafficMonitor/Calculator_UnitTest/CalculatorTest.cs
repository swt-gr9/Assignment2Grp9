using System;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator_UnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase(0, 5, 0.1, 50)]
        [TestCase(5, 0, 0.1, 50)]
        [TestCase(5, 5, 0.1, 70.0711)]
        public void TestSpeedCorrectSpeed(int a, int b, int c, double result)
        {
            Assert.That(Calculator.SHCalculator.GetCurrentSpeed(a,b,c), Is.EqualTo(result));
        }
    }
}
