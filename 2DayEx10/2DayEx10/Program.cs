using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DayEx10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcabdefe";
            Dictionary<char, int> hash = new Dictionary<char, int>();
            char[] c=str.ToCharArray();
            
            for (int i=0; i<c.Length; i++)
            {
                if (hash.ContainsKey(c[i]))
                {
                    hash[c[i]] += 1;
                }
                else
                {
                    hash.Add(c[i], 1);
                }
            }

            for(int i=0; i<c.Length; i++)
            {


                if (hash[c[i]] == 1)
                { 
                    Console.WriteLine(c[i]);
                    return;
                }
            }
        }
    }
}
