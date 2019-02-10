using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상클래스
{
    public abstract class Dog
    {
        public string Name
        {
            get; set;
        }
        public abstract void jitda();
       
    }

    public class Puddle : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + "푸들푸들~");

        }
        public void Work()
        {
            Console.WriteLine(Name + "가 일한다.");

        }
    }

    public class Jindo : Dog
    {
        public override void jitda()
        {
            Console.WriteLine(Name + "진도진도~");

        }

        public void Run()
        {
            Console.WriteLine(Name + "가 달린다.");
        }
    }

    class DogManager
    {
        static void Main(string[] args)
        {
            Dog p = new Puddle();
            p.Name = "푸들이";

            p.jitda();
            ((Puddle)p).Work();

            Dog j = new Jindo();
            j.Name = "진도이";
            j.jitda();
            ((Jindo)j).Run();


        }
    }
}
