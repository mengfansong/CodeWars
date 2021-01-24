using System;

namespace A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            
            while((str = Console.ReadLine() )!= null)
            {
                string[] str1 = str.Split(" ");


                Console.WriteLine(int.Parse(str1[0]) + int.Parse(str1[1]));
            }
            
            
        }
    }
}
