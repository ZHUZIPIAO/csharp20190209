using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace 쓰레드_예제3
{
    class Program
    {
        public static AutoResetEvent autoEvent = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            //sleeperThread = new Thread(ThreadToSleep);
            //sleeperThread.Start();
            //sleeperThread.Interrupt();
        }
        private static void ThreadToSleep()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("[Sleeper : " + i++ + "]");

                if (i == 9)
                {
                    try
                    {
                        Console.WriteLine("i 가 9 가 되어 1 초쉼...");
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine("ThreadInterruptedException ...");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
