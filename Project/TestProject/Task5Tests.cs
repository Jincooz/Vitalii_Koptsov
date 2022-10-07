using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Task5Tests
    {
        [Test]
        public void DealWithFriendList_DenFriendList_ReturnsRequiredOutput()
        {
            var s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            var requiredResult = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            string result = Tasks.Task5.DealWithFriendList(s);
            Assert.That(result, Is.EqualTo(requiredResult));
        }

        [Test]
        public void DealWithFriendList_EmptyString_ThrowsException()
        {
            var s = "";
            TestDelegate action = () => Tasks.Task5.DealWithFriendList(s);
            Assert.Throws<Exception>(action);
        }
    }
}
