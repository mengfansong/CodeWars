using System;
using System.Collections;

namespace Directions_Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            

            foreach (var item in dirReduc(a))
            {
                Console.WriteLine(item);
            }
        }


        public static string[] dirReduc(String[] arr)
        {
            Stack stack = new Stack();
            stack.Push(arr[0]);
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(arr[i]);
                }else if (GetNegative(arr[i]) != stack.Peek().ToString()){
                    stack.Push(arr[i]);
                }
                else
                {
                    stack.Pop();
                }

                    
            }
            Object[] o = stack.ToArray();
            string[] strs = new string[o.Length];
            for (int i = 0; i < o.Length; i++)
            {
                strs[i] = o[o.Length-1-i].ToString();
            }
            return strs;

        }

        public static string GetNegative(string str)
        {
            switch (str)
            {
                case "NORTH":
                    return "SOUTH";
                case "SOUTH":
                    return "NORTH";
                case "WEST":
                    return "EAST";
                case "EAST":
                    return "WEST";
                default:
                    return "";                    
            }
        }


    }
}
