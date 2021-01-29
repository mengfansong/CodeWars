using System;
using System.Collections.Generic;

namespace Sort_the_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = SortArray(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            
        }


        public static int[] SortArray(int[] array)
        {
            List<int> list1 = new List<int>();              //奇数的下标
            List<int> list2 = new List<int>();              //奇数的值
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 == 1)
                {
                    list1.Add(i);
                    list2.Add(array[i]);
                }
            }
            list2.Sort();       //对奇数排序

            for (int i = 0,j=0; i < array.Length && j<list1.Count; i++)
            {
                if (i==list1[j])
                {
                    array[i] = list2[j];
                    j++;
                }
            }

            return array;
        }
    }
}
