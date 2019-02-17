using System;





namespace Akadia.NoDelegate

{
   

    public class MyClass
        
    {
        
        public void Process()

        {

            Console.WriteLine("Process() begin");

            Console.WriteLine("Process() end");

        }

    }



    public class Test

    {
        private delegate void Mydelegate();

        static void Main(string[] args)

        {

            //MyClass myClass = new MyClass();

            //myClass.Process();
            Mydelegate mydelegate = new Mydelegate(new MyClass().Process);
            mydelegate();
        }

    }

}