using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace 멀티쓰레드예제5
{
    class Program
    {
        static int mysum = 0;
        static void Sum(object n)
        {
            int sum = 0;
            int[] number = (int[])n;
            for (int i = number[0]; i <= number[1]; i++)
            {
                sum += i;
            }
            mysum += sum;
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(()=>Sum(new int[] { 1, 10 }));
            //sum method를 무명함수를 이용하여 호출함
            Thread t2 = new Thread(new ParameterizedThreadStart(Sum));
            Thread t3 = new Thread(new ThreadStart(() => Sum(new int[] { 21, 30 })));
            Thread t4 = new Thread(new ThreadStart(() => Sum(new int[] { 31, 40 })));
            Thread t5 = new Thread(new ThreadStart(() => Sum(new int[] { 41, 50 })));
          
            t1.Start(new int[] {1,10}); t2.Start(); t3.Start(); t4.Start(); t5.Start();
            t1.Join(); t2.Join(); t3.Join(); t4.Join(); t5.Join();
            Console.WriteLine(mysum);
        }
    }
}