using System;
namespace Power;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number1: ");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number2: ");
        int number2=int.Parse(Console.ReadLine());
        int powerOfNumber=1;
        for(int i=1;i<=number2;i++)
        {
            powerOfNumber*=number1;
        }
        System.Console.WriteLine("Power the number is "+powerOfNumber);
    }
}
