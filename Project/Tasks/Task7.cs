using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Task7
    {
        public static string GetIPFromUInt32(uint numIp)
        {
            string[] segments = new string[4];
            for (int i = 0; i < 4; i++)
            {
                int segmentNumber = (int)(numIp / Math.Pow(256, i) % 256);
                segments[3-i] = segmentNumber.ToString();
            }
            return String.Join('.', segments);
        }
    }
}
