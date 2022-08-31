using System;
using System.Collections.Generic;
using System.Linq;

namespace taks2_pre_mcc_metrodata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Menghitung Luas Bangun Datar");
            Console.WriteLine("------------------------------------\n");

            //  Square
            Console.Write("Masukkan panjang sisi persegi? ");
            double side = double.Parse(Console.ReadLine());
            Square square1 = new Square(side);
            double squareArea = square1.GetArea();
            Console.WriteLine("Luas persegi adalah " + squareArea);

            // circle 
            Console.Write("Masukkan radius lingkaran? ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle1 = new Circle(side);
            double circleArea = circle1.GetArea();
            Console.WriteLine("Luas lingkaran adalah " + circleArea);

            // Triangle
            Console.Write("Masukkan alas segitiga? ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi segitiga? ");

            double height = double.Parse(Console.ReadLine());
            Triangle triangle1 = new Triangle(width, height);
            double triangleArea = triangle1.GetArea();
            Console.WriteLine("Luas segitiga adalah " + triangleArea);

            // Rectangle
            Console.Write("Masukkan lebar persegi panjang? ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi persegi panjang? ");

            double width2 = double.Parse(Console.ReadLine());
            Triangle rectangle1 = new Triangle(length, width2);
            double rectangleArea = rectangle1.GetArea();
            Console.WriteLine("Luas persegi panjang adalah " + rectangleArea);
        }
    }
}
