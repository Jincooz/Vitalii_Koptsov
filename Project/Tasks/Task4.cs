using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task4
    {
        public static int CountPairsWithSum5(int[] ints)
        {
            int sum = 0;
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            foreach (int i in ints)
            {
                if(pairs.ContainsKey(i))
                {
                    sum++;
                }
                if (pairs.ContainsKey(5 - i))
                {
                    pairs[5 - i]++;
                }
                else
                {
                    pairs.Add(5 - i, 0);
                }
            }
            return sum;
        }
    }
}
