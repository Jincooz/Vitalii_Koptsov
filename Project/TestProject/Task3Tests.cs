using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Task3Tests
    {
        [Test]
        public void DigitalRoot_NumberThatLowerThen10_ResturnsSameNumber()
        {
            int number = 5;
            var result = Tasks.Task3.DigitalRoot(number);
            Assert.That(result, Is.EqualTo(number));
        }

        [TestCase(100, 1)]
        [TestCase(123, 6)]
        [TestCase(155, 2)]
        [TestCase(2412455, 5)]
        public void DigitalRoot_NumberThatBiggerThen10_ResturnsDigitalRootOfThisNumber(int number, int expectedResult)
        {
            var result = Tasks.Task3.DigitalRoot(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
