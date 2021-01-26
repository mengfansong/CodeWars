using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 17,23, 5, 17, 66, 4, 32, 8, 17, 1, 55, 27 };
			Sort(array);        //冒泡排序
            foreach (var item in array)
            {
				Console.Write(item+" ");
            }
            int[] array2 = { 17, 23, 5, 17, 66, 4, 32, 8, 17, 1, 55, 27 };
            Console.WriteLine();
            QuickSort(array2,0,array2.Length-1);        //快速排序
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
        }

		//冒泡排序
		static void Sort(int[] arr)//传递一个数组排序
		{
			//冒泡排序
			for (int i = 0; i < arr.Length - 1; i++)
			{
				for (int j = 0; j < arr.Length - 1 - i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
					}
				}
			}
		}


        //快速排序
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = arr[left];
                int i = left;
                int j = right;

                while (i < j)
                {                    
                    while (i < j)
                    {
                        if (arr[j] <= pivot)        //最后一个数比基准值（当前第一个值）小，把值给第一个。
                        {
                            arr[i] = arr[j];
                            //Console.WriteLine("arr[i]="+arr[i]);
                            //foreach (var item in arr)
                            //{
                            //    Console.Write(item + " ");
                            //}

                            break;
                        }
                        else
                        {                                   //继续往前找比基准值小的值。
                            j--;
                        }
                    }                    
                    while (i < j)
                    {
                        if (arr[i] > pivot)         //基准值位置后边的值，油笔
                        {
                            arr[j] = arr[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                //跳出循环 现在i==j i是中间位置
                arr[i] = pivot;
                QuickSort(arr, left, i - 1);
                QuickSort(arr, i + 1, right);
            }
        }

    }
}
