using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastExample
{
    class TypeCastExample1
    {
        public static void Main()
        {
            var v = 5; //Type을 모를떄 var 를쓰면된다 
            //var 특징은 변수의선언과초기화를 한줄에 할때만쓸수 있음 

            int a = 50000;
            try
            {
                short b = checked((short)a); // overflow를 검사하여 예외를 발생시킴
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("예외: { 0}",e.StackTrace);
            }
        }
    }
}
