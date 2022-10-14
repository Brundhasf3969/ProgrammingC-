using System;
namespace OddEven;
class Program 
{
    public static void Main(string[] args)
    {
        int number;
        bool condition;
        string condition1;
        
        do
        { 
            System.Console.WriteLine("Enter the input number: ");
            condition=int.TryParse(Console.ReadLine(),out number);
            while(!condition)
           {
            System.Console.WriteLine("Invalid input.");
            System.Console.WriteLine("Enter the input number: ");
            condition=int.TryParse(Console.ReadLine(),out number);
           }
            if(number%2==0)
            {
                System.Console.WriteLine("{0} is an even number",number);
            }
            else
            {
                System.Console.WriteLine("{0} is an odd number",number);
            }
            System.Console.WriteLine("Do you want to check another number: (yes/no): ");
            condition1=Console.ReadLine();
            while(condition1!="yes" && condition1!="no")
            {
                System.Console.WriteLine("Invalid input. Enter the valid input.");
                System.Console.WriteLine("Do you want to check another number: (yes/no): ");
                condition1=Console.ReadLine();
            }
            
        }while(condition1=="yes");
        
    }
}
