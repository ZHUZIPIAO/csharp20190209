using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제7
{
    public delegate void EventHandler();



    class Program

    {

        public static event EventHandler _show; 

 

    static void Main()

        {

            // Add event handlers to Show event. 

            _show += Dog;
            _show += Cat;
            _show += Mouse;
            _show += Mouse;



            // Invoke the event. 

            _show.Invoke();

    }



        static void Cat()

        {

            Console.WriteLine("Cat");

        }



        static void Dog()

        {

            Console.WriteLine("Dog");

        }



        static void Mouse()

        {

            Console.WriteLine("Mouse");

        }

    }
}
