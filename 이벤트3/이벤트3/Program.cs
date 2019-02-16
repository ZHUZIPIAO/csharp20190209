using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트3
{//이벤트 게시자 클래스
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        //이벤트 처리를 위한 델리게이트 정의
        public event EventHandler MyEvent; //이벤트 정의
        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null)
            {
                MyEvent(null, null); //이벤트 발생
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            p.MyEvent += (sender, e) =>
            {
                Console.WriteLine("MyEvent 라는 이벤트 발생");
            };
            p.Do();

        }
    }
}
