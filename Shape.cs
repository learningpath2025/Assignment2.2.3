using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._3
{
    internal abstract class Shape
    {
        int id { get; set; }
        string? name { get; set; }
        string? color { get; set; }
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
}
