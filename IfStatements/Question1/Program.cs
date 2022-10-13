using System;
namespace OddEven;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        if(num%2==0)
        {
            System.Console.WriteLine("{0} is a Even integer",num);
        }
        else
        {
            System.Console.WriteLine("{0} is an Odd integer",num);
        }
    }
}
