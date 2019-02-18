using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제4
{
    class Student
    {

        private string code = "N.A";

        private string name = "not known";

        private int age = 0;



        // Declare a Code property of type string:

        public string Code
        {

            get;
            set;

        }



        // Declare a Name property of type string:

        public string Name
        {

            //name 은 현재 다른것이다 해주려면 
            //this.name=name 해줘야함 get set 을 재정의해야함

            get { return this.name; }
            set { this.name = value; }

        }



        // Declare a Age property of type int:

        public int Age
        {

            get;
            set;

        }

        public override string ToString()
        {

            return ($"student Info:Code ={this.Code},Name:={Name},Age={Age}");

        }

    }



    class ExampleDemo
    {

        public static void Main()
        {



            // Create a new Student object:

            Student s = new Student();



            // Setting code, name and the age of the student

            s.Code = "001";

            s.Name = "Zara";

            s.Age = 9;

            Console.WriteLine("Student Info: {0}", s);



            //let us increase age

            s.Age += 1;

            Console.WriteLine("Student Info: {0}", s);

            Console.ReadKey();

        }

    }

}
