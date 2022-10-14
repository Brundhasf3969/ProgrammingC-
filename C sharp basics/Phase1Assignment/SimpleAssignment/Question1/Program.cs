using System;
namespace IchesToCentimeter;
class Program 
{
    public static void Main(string[] args)
    {
        double centimeter;
        System.Console.WriteLine("Enter the number: ");
        float iches=float.Parse(Console.ReadLine());
        centimeter=iches*2.54;
        System.Console.WriteLine("{0} iches equal to {1}",iches,centimeter);
    }
}
