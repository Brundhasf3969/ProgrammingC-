using System;
namespace Number;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        System.Console.WriteLine("Enter the number: ");
        bool condition=int.TryParse(Console.ReadLine(),out number);
        do
        {
             if(true)
             {
                if(number>0 && number<=10)
                {
                    System.Console.WriteLine("Input: "+number);
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
        }while(!condition);
    }
}