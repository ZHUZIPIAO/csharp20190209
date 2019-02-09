using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//system. namespace에있는것을쓰겠다=using 

namespace HelloWorld
{
    class A { }
    //네임스페이스.class 
    /**
        클래스= 설계도 프로토타이핑,구조 디자인 
        객체 = 클래스가 구체화된것 실제실물 
    
    */
    class Program
    {
        int i; // 멤버, 필드, 인스턴스 변수 
        static int j; //멤버, 변수, 클래스 변수 , static 이붙으면 new 안하고 다이렉트로 접근할수있다.  
        //static 전역변수, 공유변수. 초기화 1회성
        static void Main(string[] args) //멤버, 메소드  
        {


            //콘솔로 출력하는 형식 3가지  
            string name = "홍길동";
            int k = 99;

            Console.WriteLine($"Hello c#{name}"); //dynamic string {}로 값을넣음
            Console.WriteLine("Hello c#"+name); 
            Console.WriteLine("Hello c#{0}{1}",name,k);
            //네임스페이스 (System.) 분류이름..
        }
    }
}
