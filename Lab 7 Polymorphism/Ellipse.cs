using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Ellipse : Geometry
    {
        public double AAxis { get; set; }
        public double BAxis { get; set; }
        public string Name { get; set; }
        public Ellipse()
        {
            AAxis = 5;
            BAxis = 8;
            Name = "Ellipse";
        }

        public override double Area()
        {
            double area = 3.14 * AAxis * BAxis;
            return area;
        }
    }
}
