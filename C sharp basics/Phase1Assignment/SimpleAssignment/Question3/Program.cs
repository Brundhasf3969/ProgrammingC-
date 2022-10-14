using System;
namespace CelsiusToFahreheit;
class Program 
{
    public static void Main(string[] args)
    {
        double fahrenheit;
        System.Console.WriteLine("Enter the celsius value: ");
        int celsius=int.Parse(Console.ReadLine());
        fahrenheit=(double)celsius*(9/5)+32;
        System.Console.WriteLine("Fahrenheit = "+Math.Round(fahrenheit,2));
    }
}
