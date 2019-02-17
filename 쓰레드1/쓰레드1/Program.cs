using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace 쓰레드1
{

    class Program
    {
        public void FirstWork()
        {
            for(int i=1; i<100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);
            }
        }
        public void SecondWork()
        {
            for(int i=0; i<100; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("s{0}", i);

            }
        }
        [MTAThread]
        static void Main(string[] args)
        {
            Program t = new Program();
            //Thread는 생성자에 ThreadStart형 Delegate를 인자로 받는다.
            Thread first = new Thread(t.FirstWork);
            Thread second = new Thread(new ThreadStart(t.SecondWork));
            first.Priority = ThreadPriority.Lowest;
            second.Priority = ThreadPriority.Highest;
            first.Start(); second.Start();
        }
    }
}
