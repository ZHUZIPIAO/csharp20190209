using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 입력숫자의합
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력숫자:");

            string str = Console.ReadLine();

            int num;
            bool isNum = int.TryParse(str, out num);

            if(isNum == false)
            {
                Console.WriteLine("숫자를 입력해 주세요");
                return;
            }

            Console.Write($"{num}까지의 숫자 : ");
            

            for(int i =1; i<=num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write($"{num}까지의 짝수의합은: ");
            int sum = 0;
            int j = 1;
            do
            {
                if (j % 2 == 0)
                {
                    sum += j;
                }
                j++;


            } while (j <= num);

            Console.WriteLine(sum);
        }
    }
}
