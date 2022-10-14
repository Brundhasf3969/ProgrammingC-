using System;
namespace PrimeNumber;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number : ");
        int num=int.Parse(Console.ReadLine());
        int temp=0;
        for(int i=2;i<=num/2;i++)
        {
            if(num%i==0)
            {
                temp=1;
            }
        }
        if(temp==0 || num==2 || num==3)
        {
            System.Console.WriteLine("{0} is prime number.",num);
        }
        else
        {
            System.Console.WriteLine("{0} is not a prime number.",num);
        }
    }
}
