using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DayEx4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("두 수를입력하세요");

            string str= Console.ReadLine();

            string[] strr = str.Split(',');
            int[] num = new int[2];
            for(int i=0; i<strr.Length; i++)
            {
                
                bool isNum = int.TryParse(strr[i], out num[i]);

                if (isNum == false)
                {
                    Console.WriteLine("입력된 숫자가 올바르지 않습니다.");
                }
                
            }

            int temp = 0;

            if (num[0] > num[1])
            {
                temp = num[0];
                num[0] = num[1];
                num[1] = temp;
            }
            int sum = 0;
            bool isPrime = true;

            for (int i=num[0]; i<=num[1]; i++)
            {



            }
            Console.WriteLine(sum);

        }
        
        
    }
}
