using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 델리게이트익명메소드
{
    class Program
    {
        private  delegate int Calc(int i, int j);
        static void Main(string[] args)
        {
            //Calc c = MySum;
            //Console.WriteLine("1+2={0}", c(1, 2));
            //Calc c1 = delegate(int i, int j)
            //{
            //    return i + j;
            //};
            Calc c1 = (i,j) => i + j;// 람다식무명메소드, 무명함수
            //식이오는걸 식람다 무조건리턴되게설계되어있음
            Console.WriteLine("3+4={0}", c1(3, 4));

        }
        static int MySum(int i, int j)
        {
            return i + j;
        }
    }
}
