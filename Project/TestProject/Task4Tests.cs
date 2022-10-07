using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Task4Tests
    {
        [TestCase(new int[] { 1, 2, 6, 9 })]
        [TestCase(new int[] { })]
        public void CountPairsWithSum5_NoSumEqualsFive_ReturnsZero(int[] ints)
        {
            var result = Tasks.Task4.CountPairsWithSum5(ints);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2)]
        [TestCase(new int[] { 1, 4, 6, 8 }, 1)]
        public void CountPairsWithSum5_WithSumsEqualsFive_ReturnsAmountOfPairs(int[] ints, int expectedResult)
        {
            var result = Tasks.Task4.CountPairsWithSum5(ints);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void CountPairsWithSum5_WithManyAmountsOfSameDigitWhichHavePair_ReturnsAmountOfPairsWhereThisDigitsCountsIndependetly()
        {
            var ints = new int[] { 1, 3, 2, 3, 3 };
            var result = Tasks.Task4.CountPairsWithSum5(ints);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
