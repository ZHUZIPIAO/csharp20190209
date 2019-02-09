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
