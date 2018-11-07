using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2_Лычагин
{

    class Program
    {

        interface IPrint
        {
            void Print();
        }
        abstract class Figure
        {
            public string Type
            { get; protected set; }
            protected double a, b;
            public abstract double Area();
        }
        class Rectangle : Figure, IPrint
        {

            public Rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
                this.Type = "Rectangle";
            }
            public Rectangle(double a)
            {
                this.a = a;
                this.Type = "Square";
            }
            public override string ToString()
            {
                if (this.Type == "Rectangle")
                {
                    return this.Type + "\n" + "Length is: " + a + "\n" + "Width is: " + b + "\n" + "Area is: " + Area();
                }
                else
                {
                    return this.Type + "\n" + "Length and width is: " + a + "\n" + "Area is: " + Area();
                }
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                if (this.Type == "Rectangle")
                {
                    return a * b;
                }
                else
                {
                    return a * a;
                }
            }
        }
        class Circle : Figure, IPrint
        {

            public Circle(double a)
            {
                this.a = a;
                this.Type = "Circle";
            }
            public override string ToString()
            {
                return this.Type + "\n" + "Radius is: " + a + "\n" + "Area is: " +
                    Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return 3.14 * a * a;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("This program is made to calculate area of figure \n\n");
            Console.WriteLine("Area of what figure do you want to calculate? \n");
            Console.WriteLine("Press 1 if you choose Circle");
            Console.WriteLine("Press 2 if you choose Rectangle");
            Console.WriteLine("Press 3 if you choose Square");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {

                Console.WriteLine("Write the radius of your circle:");
                int a = Convert.ToInt32(Console.ReadLine());
                Circle circle = new Circle(a);
                circle.Print();
                Console.ReadKey();
            }
            if (n == 2)
            {
                Console.WriteLine("Write the length of your rectangle:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write the width of your rectangle:");
                int c = Convert.ToInt32(Console.ReadLine());
                Rectangle rectangle = new Rectangle(b, c);
                rectangle.Print();
                Console.ReadKey();
            }
            if (n == 3)
            {
                Console.WriteLine("Write the length of one side of your square:");

                int d = Convert.ToInt32(Console.ReadLine());
                Rectangle square = new Rectangle(d);
                square.Print();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong number! Try again please!");
                Console.ReadKey();
            }


        }
    }
}

