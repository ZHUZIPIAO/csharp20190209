using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest
{
    class Emp:Object
    {
        //지울수 있다
        //private int empno; //인스턴스변수


        //public void SetEmpno(int empno) //Setter
        //{
        //    this.empno = empno;
        //}
        //public int GetEmpno() //Getter
        //{
        //    return this.empno;
        //}

        public int Empno //자동 구현 속성 
        {
            get; set; 
        }
        //public int Empno //일반속성 //Property
        //{
        //    get
        //    {
        //        return this.empno;
        //    }
        //    set
        //    {
        //        this.empno = value;
        //    }
        //}

        //부모 tostring을 재정의하겠다는 의미 (override)  
        //emp 의부모는 object임 (부모가 없다고 생각되면 object 가 부모임) 
        //public override string ToString()
        //{
        //    return $"[사원 : {empno}]";
        //}
    }

    class EmpTest
    {
        static void Main(string[] args)
        {
            //static붙은 애들은 안붙은 애들을 함부로다룰수 없다. 소속을  나타내서 표기해야함
            //객체 참조변수
            Emp e = new Emp();
            //e.SetEmpno(999);
            //property 는 변수 처럼 쓸수 있다.
            Console.WriteLine(e.Empno=999);
            Console.WriteLine(e);
            Console.WriteLine(e.ToString());
        }
    }
}




