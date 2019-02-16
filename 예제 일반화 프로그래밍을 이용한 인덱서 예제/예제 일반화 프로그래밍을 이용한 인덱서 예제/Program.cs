using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_일반화_프로그래밍을_이용한_인덱서_예제
{
    class Ojc<T>
    {
        private T[] ojcArray = new T[10];
       //자기자신 객체에인자를받아서 쓸수있음
       
        public T this [int i]
        {
            get
            {
                return ojcArray[i];
            }
            set
            {
                ojcArray[i] = value;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ojc<string> ojc1 = new Ojc<string>();
            ojc1[0] = "Hello, OJC";
            //string s = ojc1[0];
            System.Console.WriteLine(ojc1[0]);
            Ojc<int> ojc2 = new Ojc<int>();
            ojc2[0] = 999;
            ojc2[1] = 987;
            System.Console.WriteLine(ojc2[0]);
            System.Console.WriteLine(ojc2[1]);
        }
    }
}
