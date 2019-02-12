using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DayEx5
{
    class Emp

    {

        string name;

        //기본생성자, new할때 호출, 객체를 초기화

     

        public Emp(string name="홍길이")  //생성자, 생성자 오버로딩

        {

            this.name = name;

            Console.WriteLine("EMP 객체생성..." + name);

        }

    }

    class EmpTest

    {

        static void Main(string[] args)

        {

            Emp e = new Emp();

            Emp e1 = new Emp("광개토");

        }

    }
}
