using System;
using System.Collections.Generic;

namespace Snail_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            int[] result = Snail(array);            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }            
        }

        public static int[] Snail(int[][] array)
        {
            int n = array.Length;
            int[] arr = new int[n * n];
            int index = 0;
            if (array[0].Length == 0)
            {
                return array[0];
            }
            for (int i = 0, j = 0; n > 0; n -= 2, ++j)
            {
                for (var k = 0; k < n - 1; ++k, ++j)
                {
                    arr[index] = array[i][j];
                    index++;
                }
                for (var k = 0; k < n - 1; ++k, ++i)
                {
                    arr[index] = array[i][j];
                    index++;
                }
                for (var k = 0; k < n - 1; ++k, --j)
                {
                    arr[index] = array[i][j];
                    index++;
                }
                for (var k = 0; k < n - 2; ++k, --i)
                {
                    arr[index] = array[i][j];
                    index++;
                }
                arr[index] = array[i][j];
                index++;
            }
            return arr;
        }
    }
}
