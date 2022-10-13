using System;
namespace Multiplicatin;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++)
        {
            System.Console.WriteLine("{0} * {1} = {2}",number,i,number*i);
        }
    }
}
