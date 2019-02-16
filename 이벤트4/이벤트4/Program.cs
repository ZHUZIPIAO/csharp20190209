using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트4
{//이벤트 발생시 넘길 데이터(System.EventArgs 에서 파생)
    class EventPublisherArgs :EventArgs
    {
        public string myEventData;
        public EventPublisherArgs(string myEventData)
        {
            this.myEventData = myEventData;
        }
    }
    //이벤트 게시자 클래스
    class EventPublisher
    {
        //이벤트 처리를위한 델리게이트 정의
        //public delegate void MyEventHandler(object sender, EventPublisherArgs e);

        //public event MyEventHandler MyEvent; //이벤트 정의
        public event EventHandler MyEvent;
        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args); //이벤트 발생
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            p.Do();
        }
        //MyEvent 이벤트가 발생하면 호출되는 메서드
        //EventPublisherArgs 가 이벤트 발생시 넘어오는 데이터이다.
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
            Console.WriteLine("이벤트 매개변수 : " +((EventPublisherArgs) e).myEventData);
        }
    
    }
}
