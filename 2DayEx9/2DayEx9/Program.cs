using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DayEx9
{
    class Program
    {
      
            static void Main(string[] args)
            {
                //String의 문자 붙이기 속도
                const int loop_count = 100000;
                long start = DateTime.Now.Ticks;
                String test = null;
                for (int i = 0; i < loop_count; i++)
                {
                    test += "testtest";
                }
                long end = DateTime.Now.Ticks;
                DateTime DT = new DateTime(end - start);
                Console.WriteLine("String 소요시간은 {0}초 입니다.", DT.Second);

                //StringBuilder의 문자 붙이기 속도
                start = DateTime.Now.Ticks;
                StringBuilder test2 = new StringBuilder();
                for (int i = 0; i < loop_count; i++)
                {
                    test2.Append("testtest");
                }
                end = DateTime.Now.Ticks;
                DT = new DateTime(end - start);
                Console.WriteLine("String Buider 소요시간은 {0}초 입니다.", DT.Second);

                Console.WriteLine("Press Any key...");
                Console.ReadLine();
            }
        

        /*
         * String과 StringBuilder의 가장 큰 차이점은 수정할 수 있나 없냐의 차이입니다. 
         * String의 경우에는 수정할 때 새로 인스턴스를 생성하는 형태이지만 
         * StringBuilder의 경우는 지정된 값이 추가, 수정, 삭제가 이루어지는 형태이기에
         * 메모리 사용률, 속도 면에서 String보다 유용합니다.

         */
    }
}
