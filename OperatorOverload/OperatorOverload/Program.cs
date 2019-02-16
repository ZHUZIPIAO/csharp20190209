using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Adder
    {
        public int val;
        public static Adder operator+(Adder op1, Adder op2)
        {
            Adder obj = new Adder();
            obj.val = op1.val + op2.val;
            return obj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adder a1 = new Adder(); a1.val = 1;
            Adder a2 = new Adder(); a2.val = 1;
            Adder a3 = a1 + a2;
            Console.WriteLine($"{a3.val}");
        }
    }
}
