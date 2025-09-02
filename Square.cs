using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    internal class Square : Shape
    {
        int side { get; set; }
        public Square() { }
        public Square(int side)
        {
            this.side = side;
        }
        public override double CalculateArea()
        {
            return side * side;
        }
    }
}
