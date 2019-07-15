using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class ShapeHolder : IProtoType<ShapeHolder>
    {
        public List<Shape> shapes { get; set; }

        public ShapeHolder(List<Shape> shapes)
        {
            this.shapes = shapes;
        }
        public ShapeHolder clone()
        {
            List < Shape > shtot = new List<Shape> { };

            foreach (Shape s in shapes)
            {
                shtot.Add(s.clone());
            }

            return new ShapeHolder(shtot);
        }
    }
}
