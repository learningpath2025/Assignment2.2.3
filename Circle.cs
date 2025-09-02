using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    internal class Circle : Shape
    {
        int radius { get; set; }
        public Circle() { }
        public Circle(int radius)
        {
            this.radius = radius;
        }
        
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
