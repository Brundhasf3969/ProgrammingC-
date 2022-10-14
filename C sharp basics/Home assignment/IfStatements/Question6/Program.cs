using System;
namespace Temperature;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the temperature centigrade :");
        int temp=int.Parse(Console.ReadLine());
        if(temp<=0)
        {
            System.Console.WriteLine("Freezing weather");

        }
        else if(temp>0 && temp<=10)
        {
            System.Console.WriteLine("Very cold weather");

        }
        else if(temp>10 && temp<=20)
        {
            System.Console.WriteLine("Cold weather");

        }
        else if(temp>20 && temp<=30)
        {
            System.Console.WriteLine("Normal Temperature");
        }
        else if(temp>30 && temp<=40)
        {
            System.Console.WriteLine("Its a hot");

        }
        else
        {
            System.Console.WriteLine("Its very hot");
        }
    }
}