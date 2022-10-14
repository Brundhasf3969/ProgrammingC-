using System;
namespace PrimeNumber;
class Program 
{
    public static void Main(string[] args)
    {
        PrimeNumber();
        void PrimeNumber()
        {
            System.Console.WriteLine("Enter the number : ");
            int number=int.Parse(Console.ReadLine());
            int temp=0;
            for(int i=2;i<number/2;i++)
            {
                if(number%i==0)
                {
                    temp=1;
                }
            }
            if(temp==0)
            {
                System.Console.WriteLine("{0} is a prime number.",number);
            }
            else
            {
                System.Console.WriteLine("{0} is not a prime number.",number);
            }
        }
    }
}
