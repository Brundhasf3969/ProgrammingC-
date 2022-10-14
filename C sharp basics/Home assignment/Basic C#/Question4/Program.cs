using System;
namespace Cylinder;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radious of cylinder: ");
        float radious=float.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the height of cylinder: ");
        float height=float.Parse(Console.ReadLine());
        float volume=(float)3.14*radious*radious*height;
        System.Console.WriteLine("Volume= "+volume);
    }
}