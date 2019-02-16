using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMain
{
    class SumTest<T>
    {
        public T Sum(T i, T j)
        {
            return (dynamic)i + (dynamic)j;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SumTest<int> s1 = new SumTest<int>();
            Console.WriteLine("정수의 합 : {0} + {1} = {2} ", 1, 2, s1.Sum(1, 2));
            SumTest<double> s2 = new SumTest<double>();
            Console.WriteLine("실수의 합 : {0:f} + {1:f} = {2:f} ", 1.0, 2.0, s2.Sum(1.0, 2.0));
        }
    }
}
