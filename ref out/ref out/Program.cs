using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    class Program
    {
        //static void Swap(ref int a, ref int b)
        //{

        //    int tmp = a; a = b; b = tmp;
        //}
        static void Swap(out int a, out int b)
        {
            a = 10; b = 20;

            int tmp = a; a = b; b = tmp;
        }
        static void Main(string[] args)
        {
            int a; int b; // ref 는 초기화가되어있어야한다.
            //out 은 초기화안되도 된다.

            //Console.WriteLine("a={0}, b={1}", a, b);
            Swap(out a,  out b);
            Console.WriteLine("a={0}, b={1}", a, b);
        }
    }
}