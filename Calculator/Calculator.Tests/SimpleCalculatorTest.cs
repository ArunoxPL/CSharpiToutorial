using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTest
    {
        SimpleCalc sut = new SimpleCalc();

        [Test]
        public void ShouldAddTwoNumbers()
        {
            //var sut = new SimpleCalc();

            var result = sut.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalc();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));
        }

    }
}
