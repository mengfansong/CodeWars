using System;

namespace What_s_a_Perfect_Power_anyway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectPower(81));
        }

        public static (int, int)? IsPerfectPower(int n)
        {
            int p = (int)Math.Sqrt(n);
            int j = n;
            for (int i = 2; i <= p; i++)
            {
                for (int k = 2; k <= j; k++)
                {

                    if (Math.Pow(i, k) > n)
                    {
                        j = k;
                        break;
                    }
                    if (Math.Pow(i, k) == n)
                    {
                        return (i, k);
                    }

                }
            }
            return null;
        }
    }
}
