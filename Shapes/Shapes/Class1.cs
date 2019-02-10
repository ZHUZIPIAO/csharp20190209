using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Shapes
{
    public class Circle
    {
        double radius;
        
        public Circle(double radius=0.0d)
        {
            this.radius = radius;
        }
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
    }
}