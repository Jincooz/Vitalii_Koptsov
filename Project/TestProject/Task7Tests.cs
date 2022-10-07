using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Task7Tests
    {
        [TestCase(2149583361, "128.32.10.1")]
        [TestCase((uint)32, "0.0.0.32")]
        [TestCase((uint)0, "0.0.0.0")]
        public void GetIPFromUInt32(uint ipNum, string expectedResult)
        {
            var result = Tasks.Task7.GetIPFromUInt32(ipNum);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
