using System;

namespace Product_of_consecutive_Fib_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(productFib(4895).ToString());
            ulong[] result = productFib(800);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }        

        public static ulong[] productFib(ulong prod)
        {                        
            ulong u = 0;
            ulong f1 = 0;
            ulong f2 = 1;
            ulong temp = 0;
            ulong[] result = new ulong[3];
            if (prod == 0)
            {
                result[0] = 0;
                result[1] = 1;
                result[2] = 0;
                return result;
            }
            while (u<prod)
            {
                u = f1*f2;
                if (u==prod)
                {
                    result[0] = f1;
                    result[1] = f2;
                    result[2] = 1;
                    return result;
                }
                temp = f1;
                f1 = f2;
                f2 = f2 + temp;                
            }
            result[0] = temp;
            result[1] = f1;
            result[2] = 0;
            return result;
        }
    }
}
