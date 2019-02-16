using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트예제1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를입력해주세요");
            string num=Console.ReadLine();

            string[] n = num.Split(',');
            int [] n1 = new int[2];
            for(int i=0; i<n.Length; i++)
            {
                bool isNum = int.TryParse(n[i], out n1[i]);
                if (isNum == false)
                {
                    Console.WriteLine("에러");
                }
                
            }
            Action<int,int> Cal = new Action<int,int>(Add);
            Cal += Minus;
            Cal += Multi;
            Cal += Div;

            Cal(n1[0], n1[1]);
        }
        static void Add(int n, int m) { Console.WriteLine("더하기 : {0}", n + m); }
        static void Minus(int n, int m) { Console.WriteLine("빼기  : {0}", n - m); }
        static void Multi(int n, int m) { Console.WriteLine("곱하기 : {0}", n * m); }
        static void Div(int n, int m) { Console.WriteLine("나누기 : {0}", n / m); }
    }
}
