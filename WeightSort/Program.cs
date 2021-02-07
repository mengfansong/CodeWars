using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace WeightSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "2000 99 181 22";
            string s2 = orderWeight(s1);
            Console.WriteLine(s2);
        }

        public static string orderWeight(string strng)
        {
            List<Weight> list = new List<Weight>();
            string[] strs = strng.Split(" ");
            foreach (var item in strs)
            {
                Weight w = new Weight(item);
                list.Add(w);
            }

            list.Sort();           
            string s = "";
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i].weightString;
                if (i != (list.Count - 1))
                {
                    s += " ";
                }
            }
            return s;
              
        }

        public class Weight : IComparable<Weight>
        {
            public string weightString;
            public int weightWeight=0;

            public Weight(string str)
            {
                weightString = str;
                weightWeight = getWeight(weightString);
            }
            public int getWeight(string str)
            {
                int n = 0;
                //Console.WriteLine(weightString + ": ");
                for (int i = 0; i < str.Length; i++)
                {
                    
                    //Console.Write(str[i] + " ");
                    n += (str[i])-48;
                    //Console.WriteLine(n);
                }
                //Console.WriteLine(weightString + ": " + weightWeight);
                return n;
            }
            public int CompareTo(Weight other)
            {
                if (other == null)
                {
                    return 1;
                }
                if(this.weightWeight == other.weightWeight)         //权重相同时,逐位比较
                {
                    for (int i = 0; i < this.weightString.Length&&i<other.weightString.Length; i++)
                    {                        
                        if (this.weightString[i] != other.weightString[i])
                        {
                            return this.weightString[i] - other.weightString[i];
                        }
                    }
                    return this.weightString.Length - other.weightString.Length;                  
                }

                return this.weightWeight - other.weightWeight;
            }
        }
    }


}
