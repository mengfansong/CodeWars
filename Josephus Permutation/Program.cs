using System;
using System.Collections;
using System.Collections.Generic;

namespace Josephus_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<object> list1 = new List<object> { 1, 2, 3, 4, 5, 6, 7 };
            List<object> list2 = new List<object>();
            list2 = JosephusPermutation(list1, 3);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }            
        }
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            int[] arr = new int[items.Count];           //记录index为i的数据是否仍在列表中。
            for (int i = 0; i < items.Count; i++)
            {
                arr[i] = 1;
            }

            int count = 0;      //计数器
            int listLength = items.Count;  //剩余人数

            List<object> list = new List<object>();            
            
            while (listLength > 1)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (arr[i] == 1)        //仍在队列中
                    {
                        count++;            //记1个数
                        if (count == k)   // 记到了第k个数，该出局了。
                        {
                            arr[i] = 0;   //第i个人出局
                            listLength--;       //队列中人数减一
                            count = 0;      //计数器清零
                            list.Add(items[i]);
                        }
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)        //最后一个还在队列中的数字
                {
                    list.Add(items[i]);
                }
            }
            return list;
        }
    }
}
