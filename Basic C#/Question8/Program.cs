using System;
namespace Convese;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the meter value =");
        double meter=double.Parse(Console.ReadLine());
        System.Console.WriteLine("CM= "+meter*100);
        System.Console.WriteLine("Mm= "+meter*1000);
        System.Console.WriteLine("Inch= "+meter*39.3);
        System.Console.WriteLine("Foot= "+meter*12);
        System.Console.WriteLine("Mile= "+meter*0.00064213715277778);
    }
}