using System;

namespace YourOrderPlease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
        }

        public static string Order(string words)
        {
            string[] str = words.Split(" ");
            int size = str.Length;
            string[] strs =new string[size];
            for(int i = 0; i < str.Length; i++)
            {
                foreach(char c in str[i])
                {
                    if (c >= '0' && c <= '9')
                    {

                        int index = int.Parse(c.ToString()) - 1;
                        if (index != null)
                        {
                            strs[index] = str[i];
                        }                        
                    }
                }
            }
            string result = "";
            for (int i = 0; i < strs.Length; i++)
            {
                if (i == strs.Length - 1)
                {
                    result +=strs[i];
                }
                else
                {
                    result +=strs[i]+ " ";
                }        
            }         
            return result;
        }
    }
}
