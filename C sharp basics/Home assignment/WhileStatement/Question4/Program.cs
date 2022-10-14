using System;
namespace RangeValidation;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number: ");
        bool condition=int.TryParse(Console.ReadLine(),out number);
        while(true)
        {
            if(condition)
            {
                if(number>0 && number<=5)
                {
                    System.Console.WriteLine("Valid Input");
                    break;
                }
               else
                {
                    System.Console.WriteLine("Invalid input");
                    System.Console.WriteLine("Enter the number: ");
                    condition=int.TryParse(Console.ReadLine(),out number);
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input");
                System.Console.WriteLine("Enter the number: ");
                condition=int.TryParse(Console.ReadLine(),out number);
            }
      
        }
        
        
    }
}