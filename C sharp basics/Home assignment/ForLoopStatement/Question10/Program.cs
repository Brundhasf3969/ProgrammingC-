using System;
namespace PrimeNumber;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enthr the number: ");
        int number=int.Parse(Console.ReadLine());
        int temp=0;
        if(number==0 || number==1)
        {
            temp=1;
        }
        for(int i=2;i<=number/2;i++)
        {
            if(number%i==0)
            {
                temp++;
                break;
            }
        }
        if(temp==0)
            {
                System.Console.WriteLine("{0} is a Prime number.",number);
            }
        else
            {
                System.Console.WriteLine("{0} is not a Prime number.",number);
            }
    }
}
