using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제2_2
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
        
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            Action myAction = ()=>myclass.Process();
            myAction();
        }
    }
}
