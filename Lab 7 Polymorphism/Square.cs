using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public string Name { get; set; }
        public Square()
        {
            Side = 32.4;
            Name = "Square";
        }

        public override double Area()
        {
            double area = Side * Side;
            return area;
        }
    }
}
