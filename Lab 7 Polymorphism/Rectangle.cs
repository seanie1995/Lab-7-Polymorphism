using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Length {  get; set; }
        public double Width { get; set; }

        public string Name { get; set; }
        public Rectangle()
        {
            Length = 15;
            Width = 5;
            Name = "Rectangle";
        }
        public override double Area()
        {
            double area = Length * Width;
            return area; 
        }

       

    }
}
