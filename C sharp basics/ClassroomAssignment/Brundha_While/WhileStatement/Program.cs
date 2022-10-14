using System;
namespace whileStatement;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number: ");
        bool condition=int.TryParse(Console.ReadLine(),out(number) );
        while(!condition)
        {
            System.Console.WriteLine("Invalid input format. Please enter the input in number format.");
            System.Console.WriteLine("Enter the number: ");
            condition=int.TryParse(Console.ReadLine(),out(number) );
        }
        System.Console.WriteLine("Valid number");
    }
}
