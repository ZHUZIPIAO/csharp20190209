using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 이벤트
{
    class EventPublisher //버튼이라생각
    { 
        public delegate void MyEventHandler();
        public event MyEventHandler Click;
        public void Do()
        {
            {
                //이벤트 가입자가 있는지 확인, 만약 구독자가 존재하는지 확인안하려면
                // public event MyEventHandler MyEvent = delegate { }; 라고 하면된다.

                //if (Click != null)
                //{ Click(); 
                //이벤트 발생 }
                    Click?.Invoke();
                    //?== 마이이벤트가 널이아니면 invoke 널이면 invoke 안함


                }
            }
       }
    
    //구독자 클래스 //버튼을 쓰는클래스
    public class Subscriber{
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            //구독자의 이벤트 처리 메소드를 등록
            //이벤트를 발생하면 호출될 메소드를 정의, 여기서는 doAction 메소드 호출
            //MyEvent 라는 이벤트에 이벤트핸들러인 델리게이트를 통해 메소드를 등록
            //MyEvent 라는 이벤트가 발생하면 델리게이트가 참조하는 메소드 doAction() 실행
            p.Click += new EventPublisher.MyEventHandler(doAction);

            p.Do();
        }
        static void doAction()
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
        }
    }

}
