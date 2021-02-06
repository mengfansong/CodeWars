using System;

namespace Count_IP_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static long IpsBetween(string start, string end)
        {
            
            string[] startStr = start.Split(".");
            string[] endStr = end.Split(".");
            long startLong = Convert.ToInt32(startStr[0]) * 256 * 256 * 256 + Convert.ToInt32(startStr[1]) * 256 * 256 +
                                        Convert.ToInt32(startStr[2]) * 256 + Convert.ToInt32(startStr[3]);
            long endLong = Convert.ToInt32(endStr[0]) * 256 * 256 * 256 + Convert.ToInt32(endStr[1]) * 256 * 256 +
                                        Convert.ToInt32(endStr[2]) * 256 + Convert.ToInt32(endStr[3]);
            return endLong - startLong;
        }
    }
}
