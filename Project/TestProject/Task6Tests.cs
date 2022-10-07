using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Task6Tests
    {
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        public void NextBigger_SomeNumberWhithHaveBiger_ReturnsNextBigger(int number, int expectedResult)
        {
            var result = Tasks.Task6.NextBigger(number);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(0)]
        [TestCase(9)]
        [TestCase(111)]
        [TestCase(531)]
        public void NextBigger_SomeNumberWhithoutBiger_ReturnsNegativeOne(int number)
        {
            var result = Tasks.Task6.NextBigger(number);
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
