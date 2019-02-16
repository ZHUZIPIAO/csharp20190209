using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트테스트3
{
    delegate void OnjDelegate(int a, int b);
    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }


        static void Main(string[] args)
        {
            Program m = new Program();

            //OnjDelegate callback = (OnjDelegate)Delegate.Combine(
            //    new OnjDelegate(Plus),
            //    new OnjDelegate(Minus),
            //    new OnjDelegate(m.Multiplication),
            //    new OnjDelegate(m.Division));
            OnjDelegate CallBack = new OnjDelegate(Program.Plus);
            CallBack += new OnjDelegate(Program.Minus);
            CallBack += new OnjDelegate(m.Multiplication);
            CallBack += new OnjDelegate(m.Division);

            CallBack(4, 3);


            OnjDelegate CallBack1 = new OnjDelegate(Plus);
            OnjDelegate CallBack2 = new OnjDelegate(Minus);
            OnjDelegate CallBack3 = new OnjDelegate(m.Multiplication);
    
            OnjDelegate CallBack4 = new OnjDelegate(m.Division);
            OnjDelegate CallBack11 = CallBack1 + CallBack2 + CallBack3 + CallBack4;
            CallBack11(4, 3);
        }
    }
}
