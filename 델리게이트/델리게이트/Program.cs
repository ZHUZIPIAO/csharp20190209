using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트
{
    class Program
    {
        //private delegate int OnjSum(int i, int j);
        //r값을 리턴하지않은 것은 Action
        //리턴하면 func 을쓰면 됨 

        static void Main(string[] args)
        {
            //Func<int, int, int> myMethod = new Func<int, int, int>(Program.Sum);
            //OnjSum myMethod2 = new OnjSum(Sum);
            //OnjSum myMethod3 = Sum;

            //Console.WriteLine("두수의합 ; {0}", myMethod(10, 30));
            Action<int,int>myMethod=Sum;
            myMethod.Invoke(10, 30);
            //위아래호출동일함
            myMethod(10, 30);



        }

        static void Sum(int i, int j)
        {
            Console.WriteLine(i + j);
            //return i + j;
        }
        static int Sum(int i, int j,int k)
        {
            return i + j+k;
        }
    }
}
