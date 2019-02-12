using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DayEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i=1; i<1000; i++)
            {
                if (i.ToString().Contains("7"))
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine($"총 7은 {count}번 나옵니다.");
        }
    }
}
