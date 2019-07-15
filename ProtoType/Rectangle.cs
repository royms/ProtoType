using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType 
{
    class Rectangle : Shape
    {
        public Point Center { get; set; }

        public double Area { get; set; }

        public Rectangle(Point center, double area)
        {
            this.Center = center;
            this.Area = area;
        }

        public override string ToString()
        {
            return $"Rectangle center {Center} area = {Area}";
        }

        
        public override Shape clone()
        {
            return new Rectangle(Center.clone(), Area);
        }
    }
}
