using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    public interface Shape
    {
        double Area();
    }
    public class Square : Shape
    {
        public double Height { get; set; }
        public double Area()
        {
            return Height * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Radius * 3.14;
        }
    }
    public class Display
    {
        public void Show(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.GetType().ToString() + " " + shape.Area());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Display d = new Display();
            List<Shape> squares = new List<Shape>();
            Square s = new Square();
            s.Height = 5;
            Circle c = new Circle();
            c.Radius = 10;
            squares.Add(s);
            squares.Add(c);
            d.Show(squares);
        }
    }
}
