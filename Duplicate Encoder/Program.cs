using System;
using System.Collections.Generic;

namespace Duplicate_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = DuplicateEncode("(((((()");
            string str2 = "((((((()";

            Console.WriteLine(str);

            //Console.Write(str2[1]);
        }

        public static string DuplicateEncode(string word)
        {
            Dictionary<char,int> dict = new Dictionary<char,int>();
            word=word.ToUpper();
            foreach (char c in word)
            {                
                if (dict.ContainsKey(c) == false)
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c] += 1;
                }
            }

            foreach (KeyValuePair<char,int> kv in dict)
            {                
                if (kv.Value > 1)
                {
                    word=word.Replace(kv.Key, '1');         //把应该变成)暂存为1
                }
                else
                {                   
                    word=word.Replace(kv.Key, '2');         ////把应该变成(暂存为2
                }
            }
            word = word.Replace('1',')');
            word = word.Replace('2', '(');

            return word;
        }
    }
}
