using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트예제2
{
    delegate int SumDeli(int i, int j);

    class Program
    {

        static void Main(string[] args)
        {
            SumDeli s1 = Program.Sum1;
            SumDeli s2 = new SumDeli(Sum2);
            S(s1); S(s2);
        }


     static void S(SumDeli s){
        Console.WriteLine(s(1,2));
        }
    static int Sum1(int i, int j)
    {
        return i + j;
    }
    static int Sum2(int i, int j)
    {
        return i + j + 100;
    }

}
}
