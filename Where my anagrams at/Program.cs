using System;
using System.Collections.Generic;

namespace Where_my_anagrams_at
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = Anagrams("abcc", new List<string> { "acbc","bbcc","accb" });
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> list = new List<string>();
            foreach (var item in words)
            {
                if (SortString(word) == SortString(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public static string SortString(string str)
        {
            char[] chars = str.ToCharArray();
            int n = str.Length;
            bool flag = false;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        char temp = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }           
            string str1 = new string(chars);            
            return str1;            
        }

    }
}
