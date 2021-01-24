using System;

namespace Equal_Sides_Of_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            Console.WriteLine(FindEvenIndex(a));
            Console.WriteLine(FindEvenIndex2(a));
        }

        public static int FindEvenIndex(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int j = 0; j < i; j++)
                {                   
                    left += arr[j];
                }
                for (int k = i+1; k < arr.Length; k++)
                {
                    right += arr[k];
                }
                if (left == right)
                {
                    return i;
                }
            }
            return -1;
        }


        public static int FindEvenIndex2(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j < i)
                    {
                        left += arr[j];
                    }
                    if (j > i)
                    {
                        right += arr[j];
                    }
                }
                if (left == right)
                {
                    return i;
                }
            }
            return -1;
        }


    }
}
