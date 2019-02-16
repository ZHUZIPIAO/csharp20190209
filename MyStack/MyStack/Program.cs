using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("OJC");
            myStack.Push("ASIA");
            myStack.Push("Thank You!");

            Console.WriteLine("myStack 의 건수:{0}", myStack.Count);

            Console.WriteLine(myStack.Pop());
            //스택의 top 포인터가 가리키는 자료를 리턴, 스택에서 꺼내는것은 아님
            Console.WriteLine(myStack.Peek());

            PrintValues(myStack); //스택에 있는 두값을 출력
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0} ", obj);
            Console.WriteLine();
        }
    }
}
