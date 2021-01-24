using System;

namespace Persistent_Bugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Persistence(long n)           //39
        {

            int result = 0;

            if (n <= 9)
            {
                return result;
            }

            while (n > 9)
            {
                long temp = 1;

                while (n > 9)
                {
                    temp *= n % 10;
                    n /= 10;
                }
                n = temp * n;
                result++;
            }
            return result;
        }
    }
}
