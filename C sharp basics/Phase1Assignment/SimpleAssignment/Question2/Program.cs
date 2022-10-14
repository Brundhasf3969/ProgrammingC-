using System;
namespace AreaAndPerimeter;
class Program 
{
    public static void Main(string[] args)
    {
        double area,perimeter;
        System.Console.WriteLine("Enter the radius of the circle: ");
        double radius=double.Parse(Console.ReadLine());
        area=3.14*radius*radius;
        perimeter=2*3.14*radius;
        System.Console.WriteLine("Radius of the circle = "+radius);
        System.Console.WriteLine("Area of the circle = "+area );
        System.Console.WriteLine("Perimeter of the circle = "+perimeter);
    }
}
