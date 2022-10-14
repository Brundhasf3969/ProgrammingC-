using System;
namespace SumOfDigits;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        while(number>0)
        {
            int reminder=number%10;
            
            sum+=reminder;
            number/=10;
        }
        System.Console.WriteLine("Sum of the digits= "+sum);
    }
}