using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트문제2
{
    public delegate void MyEventHandler(int num);

    class EventPublisher
    {

        public event Action<int> MyEvnet;

        public void Do(int num)
        {

            if (num % 2 == 0)
                MyEvnet(num);
        }
    }

    class Program
    {
        static void Print(int num)
        {
            Console.WriteLine($"{num}: 짝");
        }
        static void Main(string[] args)
        {

            string n = Console.ReadLine();
            int s;
            String[] num = n.Split(',');
            EventPublisher p = new EventPublisher();
            p.MyEvnet += new Action<int>(Print);

            for (int i = 0; i < num.Length; i++)
            {

                bool isNum = int.TryParse(num[i], out s);
                if (isNum == false)
                {
                    Console.WriteLine("에러");
                    return;
                }
                else
                {
                    p.Do(s);
                }
            }

        }

    }
}
