using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문형식람다식
{
    class Program
    {
        //delegate int Sum(int[] arg);

        static void Main(string[] args)
        {
            Func<int[], int>  sumdeli = (arg) =>
            {
                int mySum = 0;
                foreach (int i in arg)
                    mySum += i;
                return mySum;
            };
            int sum = sumdeli(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("1+2+3+4+5=" + sum);
        }
    }
}
