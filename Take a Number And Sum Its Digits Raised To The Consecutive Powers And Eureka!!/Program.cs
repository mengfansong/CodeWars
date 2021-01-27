using System;
using System.Collections.Generic;

namespace Take_a_Number_And_Sum_Its_Digits_Raised_To_The_Consecutive_Powers_And_Eureka__
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] l = SumDigPow(1, 140);
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }          
        }


        public static long[] SumDigPow(long a, long b)
        {
            List<long> list = new List<long>();            
            for (long i = a; i <= b; i++)
            {
                string s = i.ToString();
                double temp = 0;                
                for (int j = 0; j < s.Length; j++)
                {
                    temp += Math.Pow(s[j]-48 ,(j+1));                    
                }
                if (i == temp)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
    }
}
