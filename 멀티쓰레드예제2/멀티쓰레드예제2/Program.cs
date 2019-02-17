using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace 멀티쓰레드예제2
{
    class Program
    {
        public bool sleep = false;
        public void FirstWork()
        {
           for(int i=0; i<20; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);
                if (i == 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉼...");
                    Thread.CurrentThread.Suspend();
                }
            }
        }

        static void Main(string[] args)
        {
            Program t = new Program();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();
            while (t.sleep == false) { }
            Console.WriteLine("first를 깨웁니다...2초후 깨어 납니다.");
            Thread.Sleep(2000);
            first.Resume();

        }
    }
}
