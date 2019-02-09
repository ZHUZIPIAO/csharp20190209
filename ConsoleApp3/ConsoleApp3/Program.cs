using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Emp { string name; void GotoOffice() { } }

    class Programmer : Emp { }

    class EmpTest
    {

        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            //if (p is Emp)
            //{
            //    Console.WriteLine("Programmer is Emp");
            //}
            //else
            //{
            //    Console.WriteLine("Programmer is not emp");
            //}

            Emp e = new Emp();

            Emp e1 = p as Emp; //왼쪽 p 를 오른쪽 emp 로형변환한다. 변환이안되면 null를 반환한다.
            Emp e2 = (Emp)p; //안되면 RUNTIME 오류를던지기 때문에 프로그램이죽는다.
        }
    }
}
