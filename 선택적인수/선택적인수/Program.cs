using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 선택적인수
{
    class Program
    {
        private int m = 88, n = 99;

        Program(int m = 0, int n = 0)
        {
            this.m = m; this.n = n;
        }
        static int Sum(int i = 0, int j = 0)
        {
            return i + j;
        }

        static void Main(string[] args)
        {
            Console.WriteLine((Sum(1, 2)));
            Console.WriteLine((Sum(j: 7)));
            Console.WriteLine(Sum());

            Program t1 = new Program();
            Console.WriteLine("m={0}, n{1}", t1.m, t1.n);
            Program t2 = new Program(1, 2);
            Console.WriteLine("m={0}, n={1}", t2.m, t2.n);
            Console.WriteLine(Minus(1, 2)); //i=1, j=2
            Console.WriteLine(Minus(1)); //i=1, j=0
            Console.WriteLine(Minus(i: 8, j: 9)); //i=8, j=9
            Console.WriteLine(Minus(j: 8, i: 9)); //i=9, j=8
            Console.WriteLine(Minus()); //i=0, j=0
        }
        static int Minus(int i = 0, int j = 0) // i, j 매개변수없이호출되면 0이 대입됨
        {
            return i - j;
        }
    }
}
