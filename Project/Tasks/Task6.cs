using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task6
    {
        public static int NextBigger(int number)
        {
            int amountOfDigit = (int)Math.Ceiling(Math.Log10(number));
            for (int i = 0; i < amountOfDigit; i++)
            {
                int curentValue = number / (int)Math.Pow(10, i) % 10;
                for (int j = i; j < amountOfDigit; j++)
                {
                    int innerValue = number / (int)Math.Pow(10, j) % 10;
                    if (curentValue > innerValue)
                    {
                        return number + (curentValue - innerValue) * ((int)Math.Pow(10, j) - (int)Math.Pow(10, i)); 
                    }
                }
            }
            return -1;
        }
    }
}
