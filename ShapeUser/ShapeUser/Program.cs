using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
namespace ShapeUser
{
    public class ShapeUser
    {
        //dll를 사용하면 shpes 가 shpesUser에복사된다. 전용 어셈블리라 한다. 
        public static void Main()
        {
            Circle c = new Circle(1.0F);
            Console.WriteLine("Area of Circle(1.0) is {0}", c.Area());
        }
    }
}
