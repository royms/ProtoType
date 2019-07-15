using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle c = new Circle(new Point(6, 10), 60);
            Circle b = new Circle(new Point(5, 5), 50.5);
            Rectangle r = new Rectangle(new Point(10, 10), 40);
            List<Shape> a = new List<Shape> { r, b, c };
            ShapeHolder s = new ShapeHolder(a);


            Console.WriteLine(c);

            ShapeHolder n = s.clone();

            c.Center.X = 99999;

            Console.WriteLine(n.shapes[2]);

            //DoStuffWithCircle(s.clone() as Circle);



            Console.WriteLine(c);
        }

        public static void DoStuffWithCircle(Circle c)
        {
            c.Center.X = 15;
            c.Area = -5;
        }
    }
}
