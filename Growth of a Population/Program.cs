using System;

namespace Growth_of_a_Population
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NbYear(1500, 5, 100, 5000));
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int year = 0;
            while(p0<p)
            {
                p0 = (int)(p0 + p0 * percent / 100d + aug);
                year++;
            }
            return year;
        }
    }
}
