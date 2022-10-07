using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task2
    {
        public static char? FirstNonRepeatingLetter(string str)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            foreach (char symbol in str)
            {
                if (countChars.ContainsKey(Char.ToLower(symbol)))
                {
                    countChars[Char.ToLower(symbol)]++;
                }
                else if (countChars.ContainsKey(Char.ToUpper(symbol)))
                {
                    countChars[Char.ToUpper(symbol)]++;
                }
                else
                {
                    countChars.Add(symbol, 1);
                }
            }
            foreach (var item in countChars)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return null;
        }
    }
}
