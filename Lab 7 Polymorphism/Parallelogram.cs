using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Parallelogram : Geometry
    {
        public double ShapeBase {  get; set; }
        public double Height { get; set; }
        public string Name { get; set; }

        public Parallelogram()
        {
            ShapeBase = 14.3;
            Height = 9.9;
            Name = "Parallelogram";
        }
        public override double Area()
        {
            double area = ShapeBase * Height;
            return area;
        }
    }
}
