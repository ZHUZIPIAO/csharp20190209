using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 사용자정의
{
    [AdditionalInfoAttribute("홍길동", "2018/10/1", Download = "http://ojc.asia")] 
    /// ㅇ= ㅇ, ㅇ=ㅇ 명령파라미터는여러개넣을수있음
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            foreach(Attribute attr in type.GetCustomAttributes(true))
            {
                AdditionalInfoAttribute info = attr as AdditionalInfoAttribute;
                if (info != null)
                    Console.WriteLine("Name={0},Update Date={1}," +
                    "Download ={2}",
                    info.Name, info.Update, info.Download);
            }
        }
    }
}
