using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalANd
{
    class LogicalAnd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정상적인AND;");

            if (Method1() & Method2())
                Console.WriteLine("Both methods returns true");
            else
                Console.WriteLine("둘중 하나의 메소드는 false");

            Console.WriteLine("\n Short-circuit AND;");
            if (Method1() && Method2())
                Console.WriteLine("Both Methods returned true");
            else
                Console.WriteLine("둘중하나의메소드는 false");

            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f); // 0x38
        }
        static bool Method1()
        {
            Console.WriteLine("메소드1...");
            return false;
        }
        static bool Method2()
        {
            Console.WriteLine("메소드2...");
            return true;
        }
    }

}
