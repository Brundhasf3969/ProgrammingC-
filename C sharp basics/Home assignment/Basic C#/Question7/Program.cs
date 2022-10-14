using System;
namespace Equation;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the value of a: ");
        int a=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the value of b: ");
        int b=int.Parse(Console.ReadLine());
        int ans=a*a+2*a*b*+b*b;
        System.Console.WriteLine("output = "+ans);
    }
}
