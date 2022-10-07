using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Task2Tests
    {
        [Test]
        public void FirstNonRepeatingLetter_String_ReturnFirstNonRepeatingLetterInThisString()
        {
            var input = "sTreSS";
            var result = Tasks.Task2.FirstNonRepeatingLetter(input);
            Assert.That(result, Is.EqualTo('T'));
        }

        [Test]
        public void FirstNonRepeatingLetter_EmptyString_ReturnsNull()
        {
            var input = "";
            var result = Tasks.Task2.FirstNonRepeatingLetter(input);

            Assert.That(result, Is.EqualTo(null));
        }

        [TestCase("aa")]
        [TestCase("bbaa")]
        public void FirstNonRepeatingLetter_StringWithRepeatingLettersOnly_ReturnsNull(string inputWithRepeatingLettersOnly)
        {
            var result = Tasks.Task2.FirstNonRepeatingLetter(inputWithRepeatingLettersOnly);
            Assert.That(result, Is.EqualTo(null));
        }
    }
}
