using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
