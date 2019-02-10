using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(j: 10, i: 20));
            Console.WriteLine(Sum(j: 10));
            Console.WriteLine(Sum(20));
            Console.WriteLine(Sum()); //메소드오버로딩이 필요 없어진다.
        }

        static int Sum(int i=0, int j=0)
        {
            return i + j;
        }
        //static int Sum(int i)
        //{
        //    return i + 0;
        //}


    }
   
}
