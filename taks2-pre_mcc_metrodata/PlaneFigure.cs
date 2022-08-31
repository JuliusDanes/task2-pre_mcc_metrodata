using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taks2_pre_mcc_metrodata
{
    public abstract class PlaneFigure
    {
        public abstract double GetArea();

        public void Display()
        {
            Console.WriteLine("Proccessing Calculate.....");
        }
    }

    public class Square : PlaneFigure
    {
        private double Side { get; set; }

        public Square(double _side)
        {
            Side = _side;
        }
        public Square()
        {
            Side = 1;
        }

        public override double GetArea()
        {
            double area = Side * Side;
            return area;
        }
    }

    public class Circle : PlaneFigure
    {
        private double Radius { get; set; }

        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public Circle()
        {
            Radius = 1;
        }
        public override double GetArea()
        {
            double area = Radius * Radius * Math.PI;
            return area;
        }
    }

    public class Triangle : PlaneFigure
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Triangle(double _side1, double _side2)
        {
            Width = _side1;
            Height = _side2;
        }

        public Triangle(double _side1)
        {
            Width = _side1;
            Height = _side1;
        }

        public Triangle()
        {
            Width = 1;
            Height = 1;
        }

        public override double GetArea()
        {
            double area = (Width * Height) / 2;
            return area;
        }
    }

    public class Rectangle : PlaneFigure
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(double _side1, double _side2)
        {
            Length = _side1;
            Width = _side2;
        }
        public Rectangle(double _side1)
        {
            Length = _side1;
            Width = 1;
        }
        public Rectangle(float _side2)
        {
            Length = 1;
            Width = _side2;
        }
        public Rectangle()
        {
            Length = 1;
            Width = 1;
        }

        public override double GetArea()
        {
            double area = Length * Width;
            return area;
        }
    }
}
