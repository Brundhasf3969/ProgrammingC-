using System;
namespace Multiplication;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int num=int.Parse(Console.ReadLine());
        int product;
        for(int i=1;i<=20;i++)
        {
            product=num*i;
            System.Console.WriteLine("{0} * {1} = {2}",num,i,product);
        }
    }
}
