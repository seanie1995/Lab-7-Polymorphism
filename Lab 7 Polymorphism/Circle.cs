using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public string Name { get; set; }
        public Circle()
        {
            Radius = 5;
            Name = "Circle";
        }
        public override double Area()
        {
            double area = 3.14 * (Radius * Radius);
            return area;
        }
    }
}
