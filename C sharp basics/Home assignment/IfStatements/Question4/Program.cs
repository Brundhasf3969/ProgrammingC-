using System;
namespace LargestNumber;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number1: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number2: ");
        int num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number3: ");
        int num3=int.Parse(Console.ReadLine());
        if (num1>num2 && num1>num3)
        {
            System.Console.WriteLine("First number is the graest among three.");
        }
        else if(num2>num3)
        {
            System.Console.WriteLine("Second number is the graest among three.");   
        }
        else 
        {
            System.Console.WriteLine("Third number is the graest among three.");
        }
    }
}
