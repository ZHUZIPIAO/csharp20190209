using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제10
{

    class Dept

    {

        public string[] emps = new string[3];

        public string this[int index]
        {
            get { return emps[index]; }
            set { emps[index] = value;  }
         }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Dept d1 = new Dept();

            d1.emps[0] = "사원1"; d1.emps[1] = "사원2"; d1.emps[2] = "사원3";



            d1[0] = "사원1"; d1[1] = "사원2"; d1[2] = "사원3";

            Console.WriteLine(d1[0]);

        }

    }

}

