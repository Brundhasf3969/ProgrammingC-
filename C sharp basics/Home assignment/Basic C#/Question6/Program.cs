using System;
namespace ProductPrice;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the price amount :");
        float priceAmount=int.Parse(Console.ReadLine());
        float totalAmount=priceAmount+priceAmount*18/100;
        System.Console.WriteLine("Total amount= "+totalAmount);
    }
}
