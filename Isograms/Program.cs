using System;
using System.Collections.Generic;

namespace Isograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsIsogram(string str)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (char c in str)
            {
                char c1;
                c1 = char.ToUpper(c);
                if (d.ContainsKey(c1) == false)
                {
                    d.Add(c1, 1);
                }
                else
                {
                    d[c1] += 1;
                }

                if (char.IsLetter(c1) == false)
                {
                    return false;
                }
            }
            foreach (KeyValuePair<char, int> kv in d)
            {
                if (kv.Value > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
