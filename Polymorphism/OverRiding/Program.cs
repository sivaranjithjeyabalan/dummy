using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding
{
    class shape
    {
        public virtual double Area()
        {
            return 0.0;
        }
        class square : shape
        {
            double a;
            public square(double a)
            {
                this.a = a;
            }
            public override double Area()
            {
                Console.WriteLine("Square Area called:");
                return a * a;
            }
        }
        class Rectangle : shape
        {
            double l, w;
            public Rectangle(double length, double width)
            {
                l = length;
                w = width;
            }
            public override double Area()
            {
                Console.WriteLine("Rectangle area called:");
                return l * w;
            }
        }
        static void Main(string[] args)
        {
            shape squareshape = new square(10);
            shape rectangleshape = new Rectangle(10, 6);
            squareshape.Area();
            rectangleshape.Area();
            Console.ReadKey();
        }
    
    }
}
