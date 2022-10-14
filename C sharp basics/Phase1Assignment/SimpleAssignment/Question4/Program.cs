using System;
namespace CurrencyConvertion;
class Program 
{
    public static void Main(string[] args)
    {
        double usd,eur,cny;
        System.Console.WriteLine("Enter the indian rupees: ");
        double inr=double.Parse(Console.ReadLine());
        usd=inr*0.0122;
        eur=inr*0.0127;
        cny=inr*0.0879;
        System.Console.WriteLine("{0} INR is equivalent to {1} usd.",inr,usd);
        System.Console.WriteLine("{0} INR is equivalent to {1} eur.",inr,eur);
        System.Console.WriteLine("{0} INR is equivalent to {1} cny.",inr,cny);
    }
}