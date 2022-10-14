using System;
namespace SugarLevel;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your sugar level: ");
        int sugarLevel=int.Parse(Console.ReadLine());
        if(50<=sugarLevel && sugarLevel<90)
        {
            System.Console.WriteLine("You are a Low Sugar Ptient.");

        }
        else if(90<=sugarLevel && sugarLevel<130)
        {
            System.Console.WriteLine("You are a Normal patient.");
        }
        else if(130<=sugarLevel && sugarLevel<140)
        {
            System.Console.WriteLine("You are a Medium level petient.");
        }
        else if(140<=sugarLevel && sugarLevel<170)
        {
            System.Console.WriteLine("You are a High level sugar patient. And try to reduce it from now ");
        }
        else if(170<=sugarLevel)
        {
             System.Console.WriteLine("You are a Very high sugar patient");
        }
        else
        {
             System.Console.WriteLine("Invalied value");
        }
    }
}
