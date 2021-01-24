using System;

namespace ToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the_stealth_warrior"));
            //Console.WriteLine(ToCamelCase("abcDefg"));
        }

        public static string ToCamelCase(string str)
        {
            char[] chars = str.ToCharArray(0,str.Length);
            str = "";
            for(int i =0;i<chars.Length; i++)
            {
                if(chars[i]== '_' || chars[i] == '-')                
                {

                    chars[i + 1] = char.ToUpper(chars[i + 1]);
                }                
                str += chars[i];
            }
            str = str.Replace("_", "").Replace("-", "");
            return str;
        }

    }
}
