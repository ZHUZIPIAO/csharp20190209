using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 소멸자
{
    class Garbage : IDisposable
    {
        private bool isDispose = false;

        private string name;
        public Garbage(string name)
        {
            this.name = name;
            Console.WriteLine("{0} 객체생성됨...", this.name);
            
        }
        ~Garbage()
        {
            if (!isDispose)
            {
                Dispose();
            }
        }
        public void Dispose() //finalize를 대체하기위해 만든것임..
        {
            isDispose = true;
            //리소스를 해제함..
            Console.WriteLine("{0}객체의 리소스 해제 OK..", name);
            
            //소멸자를 막아 버림
            GC.SuppressFinalize(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Garbage g1 = new Garbage("1번 객체"); 
            Garbage g2 = new Garbage("2번 객체");
            Garbage g3 = new Garbage("3번 객체");
            Garbage g4 = new Garbage("4번 객체");

            g1.Dispose();

            GC.SuppressFinalize(g2);
        }
    }
}
