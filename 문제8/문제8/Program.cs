using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제8
{
    public delegate void Mydelegate(int num); //이벤트 처리를 위한 델리게이트 정의



    class Program

    {

        public event Mydelegate AddEvent; // 이벤트 정의 

    static void Main()

        {

            Program p = new Program();

            p.AddEvent += new Mydelegate(Adder.Add);

            p.AddEvent(5);

            p.AddEvent(6);



            Console.WriteLine($"Sum = {Adder.sum}");

        }

    }



    public class Adder

    {

        public static int sum;

        public static void Add(int i) { sum += i; }

    }


}
