using System;
namespace CelConversion;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the amount of Celsius: ");
        int celsius=int.Parse(Console.ReadLine());
        double kelvin=(double)celsius+273.15;   
        float fahrenheit=(float)32+(celsius*9/5);
        System.Console.WriteLine("Kelvin = "+kelvin);
        System.Console.WriteLine("Fahrenheit = "+fahrenheit);
    }
}
