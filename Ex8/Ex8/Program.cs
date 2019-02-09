using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[10];
            Console.WriteLine("Input the 10 numbers :");
            int sum = 0;
            int num = 0;
            for (int i=0; i<10; i++)
            {
                Console.Write("숫자-{0} :",i+1);
                arr[i] = Console.ReadLine();
                bool isNum = int.TryParse(arr[i], out num);
                if (isNum == false)
                {
                    Console.WriteLine("올바른숫자가아닙니다.");
                    Environment.Exit(0);
                }
                sum += num;
            }

            Console.WriteLine("합 : {0}", sum);
            Console.WriteLine("평균 : {0}", sum / (double)10);
        }
    }
}
