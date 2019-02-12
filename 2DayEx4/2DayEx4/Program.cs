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
            for(int k=0; k<strr.Length; k++)
            {
                
                bool isNum = int.TryParse(strr[k], out num[k]);

                if (isNum == false)
                {
                    Console.WriteLine("입력된 숫자가 올바르지 않습니다.");
                }
                
            }

            int i = 0;

            if (num[0] > num[1])
            {
                i = num[0];
                num[0] = num[1];
                num[1] = i;
            }
            int sum = 0;
           for(; num[0]<= num[1];  num[0]++)
            {
                for(i=2; i<=num[0]; i++)
                {
                    if (num[0] % i == 0)
                    {
                        break;
                    }
                }
                if (num[0] == i)
                {
                    sum = sum + num[0];
                }
            }

            Console.WriteLine(sum);

        }
        
        
    }
}
