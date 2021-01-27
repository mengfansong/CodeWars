using System;

namespace 两数之和
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] int1 = { 2, 7, 11, 15 };
            int[] ints = TwoSum(int1,9);
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2] ;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j])==target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
}
