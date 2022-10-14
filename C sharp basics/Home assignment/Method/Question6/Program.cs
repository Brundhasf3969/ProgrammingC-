using System;
namespace FactorialNumber;
class Program 
{
    public static void Main(string[] args)
    {
        Factorial();
        void Factorial()
        {
            System.Console.WriteLine("Enter the number : ");
            int number=int.Parse(Console.ReadLine());
            int fact=1;
            for(int i=1;i<=number;i++)
            {
                fact*=i;
            }
            System.Console.WriteLine("Factorial of {0} is {1}",number,fact);

        }
    }
}
