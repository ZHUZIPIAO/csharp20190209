using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
{
    public class Dog : Object
    { 
    public string name { get; set; }
    public void jitda()
    {
        Console.WriteLine(name + "가 짖다.");

    }

    }

    public class Pudle : Dog
    {
        public void work()
        {
            Console.WriteLine(name + "가 일한다.");

        }
    }

    public class Jindo : Dog
    {
        public void run() {
            Console.WriteLine(name + "가 달린다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Object p = new Pudle();
            //p는 지역변수 stack 에올라감

            ((Dog)p).name = "푸들이"; ((Dog)p).jitda(); ((Pudle)p).work();

            Jindo j = new Jindo(); j.name = "진도이";
            j.jitda();
            j.run();
        }
    }
}
