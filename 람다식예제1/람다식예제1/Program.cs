using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 람다식예제1
{
    class Program
    {
        delegate int Calc(int i, int j);
        static void Main(string[] args)
        {
            Calc c = new Calc(MySum);
            Console.WriteLine($"1+2={c(1,2)}");

            Calc c2 = delegate (int i, int j)
            {
                return i + j;
            };

            Console.WriteLine($"3+4={c2(3, 4)}");

            Calc c3 = (int a, int b) => a + b;
            Console.WriteLine($"3+4={c3(3, 4)}");

            Calc c4 = (a, b) => a + b;
            Console.WriteLine($"3+4={c4(3, 4)}");
        }

        static int MySum(int i, int j)
        {
            return i + j;
        }
    }

    
}
