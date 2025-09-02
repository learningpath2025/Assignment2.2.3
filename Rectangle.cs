using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    internal class Rectangle : Shape
    {
        double length { get; set; }
        double breadth { get; set; }
        public Rectangle() { }
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double CalculateArea()
        {
            return length * breadth;
        }
    }
}
