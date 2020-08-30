using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asp052019.basics.oop
{
    // Override : re-implementation market (abstract / virtual / override) method from the parent class 

    // virtual method : is a method that has a body and can be overriden 
    // abstract method: is a method in abstract class with no body and must be overriden
    abstract class Shape
    {
        public int ID;
        public Shape()
        {
            Console.Write("Shape()-->");
        }
        public abstract double Area();      
    }
    class Rectangle : Shape
    {
        public int ID;
        public double Width, Height;

        public Rectangle(double w, double h)
        {
            ID = 10;            // change on the ID of the Rectangle
            base.ID = 10;       // change the ID in the Shape 

            Console.Write("Rectangle()");
            Width = w;
            Height = h;
        }
        public override double Area() { return Width * Height; }
    }

    class Triangle : Shape
    {
        public double Base, Height;

        public Triangle(double b, double h)
        {
            Console.Write("Triangle Area:");

            Base = b;
            Height = h;
        }
        public override  double Area() { return 0.5 * Base * Height; }
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[10];
            Random rand = new Random();
            int r = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                r = rand.Next(2);
                if (r == 0)
                    shapes[i] = new Triangle(rand.Next(1, 11), rand.Next(1, 11));
                else if (r == 1)
                    shapes[i] = new Rectangle(rand.Next(1, 11), rand.Next(1, 11));
               

                Console.WriteLine(shapes[i].Area());
            }


       
            Console.ReadKey();
        }
    }
}
