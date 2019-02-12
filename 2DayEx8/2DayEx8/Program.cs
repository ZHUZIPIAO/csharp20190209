using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _2DayEx8
{
     

//8. c:\GitHub 폴더에 number.txt 파일을 만들고 숫자를 1부터 100까지를 한라인씩

//   100줄에 입력한 후 이를 C# 응용프로그램에서 읽어서 합을 구하세요.
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string line;
            int sum = 0;
            using(
            StreamReader file = new StreamReader(@"C:\Users\jhpark\source\repos\ZHUZIPIAO\csharp20190209\number.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    bool isNumber = int.TryParse(line, out count);
                    if (!isNumber)
                    {
                        Console.WriteLine("올바른 숫자가 아닙니다.");
                        return;
                    }

                    sum = sum + count;

                    
                }
                Console.WriteLine($"숫자의 합은{sum} ");
            }
        }
    }
}
