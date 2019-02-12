using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DayEx6
{
    public class Emp:Object

    {

        public override string ToString()
        {
            return "This is Emp Class";
           
        }
    }

    public class ToStringMethod

    {

        static void Main()

        {

            Emp e = new Emp();

           object o = new object();



            Console.WriteLine(o.ToString());

            Console.WriteLine(e.ToString());
            
            Console.WriteLine(e);

        }

    }

    //결과

//    System.Object

//This is Emp class

//This is Emp class



}
