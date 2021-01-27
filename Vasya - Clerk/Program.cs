using System;
using System.Collections.Generic;

namespace Vasya___Clerk
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] people = new int[] { 25, 25, 25,100 };
            Console.WriteLine(Tickets(people));
        }


        public static string Tickets(int[] peopleInLine)
        {
            Dictionary<int, int> purse = new Dictionary<int, int>();
            purse.Add(25, 0);
            purse.Add(50, 0);
            purse.Add(100, 0);
            if (peopleInLine[0] != 25)
            {
                return "NO";
            }
            
            foreach (var money in peopleInLine)
            {
                purse[money] += 1;
                switch (money)
                {
                    case 25:
                        break;
                    case 50:
                        purse[25] -= 1;                        
                        break;
                    case 100:
                        if (purse[50] > 0)
                        {
                            purse[25] -= 1;
                            purse[50] -= 1;
                        }
                        else if (purse[50] == 0)
                        {
                            purse[25] -= 3;
                        }                        
                        break;
                }
                if (purse[25] < 0)
                {
                    return "NO";
                }
                if (purse[50] < 0)
                {
                    return "NO";
                }
            }
            return "YES";
        }
    }
}
