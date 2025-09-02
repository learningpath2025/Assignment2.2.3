using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    internal abstract class Shape
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }

        public abstract double CalculateArea();
    }
}
