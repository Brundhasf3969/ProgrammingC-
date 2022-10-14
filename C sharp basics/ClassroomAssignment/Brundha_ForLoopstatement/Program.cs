using System;
namespace ForStatements;
class Program 
{
    public static void Main(string[] args)
    {
        // Printing the even numbers
        System.Console.WriteLine("Even numbers between the 0 to 25:");
        for(int i=1;i<=25;i++)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }
        }
    // sum of the square of the given limit
    int output=0;
    System.Console.WriteLine("Enter the initial value: ");
    int initialValue=int.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter the final value: ");
    int finalValue=int.Parse(Console.ReadLine());
    for(int i=initialValue;i<=finalValue;i++)
    {
        output += i*i;
    }
    System.Console.WriteLine("Sum of the square of the given limit is "+output);
    }
}
