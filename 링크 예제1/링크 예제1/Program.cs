using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 링크_예제1
{
    class Onj
    {
        static bool A(int i)
        {
            return i % 2 == 1;
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var onjQuery1 = from n in num
                            where n % 2 == 1
                            orderby n
                            select n;

            var methodOnJQuery1 = num.Where(new Func<int, bool>(A));
            var methodOnJQuery2 = num.Where((A));
            var methodOnJQuery3 = num.Where(i=>i%2==1);

            foreach (int i in onjQuery1)
                Console.WriteLine("홀수 : {0}", i);
            // Query Expression.
            IEnumerable<int> onjQuery2 = //query variable
            from n in num //데이터소스 및 범위변수(필수)
            where n > 3 // 생략가능
            orderby n descending // 내림차순정렬(생략가능)
            select n; //select or group으로 끝나야 한다.
            foreach (int i in onjQuery2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
