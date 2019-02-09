using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int dan = 0;

            Console.Write("출력을 원하는 구구단 단수 :");
            bool isNum = int.TryParse(Console.ReadLine(), out dan);

            for(int i=1; i <= 9; i++)
            {
                for(int j=1; j<=dan; j++)
                {
                    Console.Write("{0}x{1}={2} ", j, i, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
