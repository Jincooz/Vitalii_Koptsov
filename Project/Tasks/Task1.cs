using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task1
    {
        public static List<int> GetIntegersFromList(List<object> innputList)
        {
            return innputList.Where(element => element is int)
                             .Select(element => (int)element)
                             .ToList();
        }
    }
}
