using System;
namespace SumOfPositiveNumbers;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        int sum=0;
        do
        {
            System.Console.WriteLine("Enter the number: ");
            number=int.Parse(Console.ReadLine());
            sum+=number;
        }while(number>0);
        System.Console.WriteLine("Sum of positive numbers = "+sum);
    }
}
