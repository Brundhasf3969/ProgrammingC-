using System;
namespace NumberPyramid;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int count=1;
        for(int i=1;i<=number;i++)
        {
            for(int j=number-1;j-i>=0;j--)
            {
                System.Console.Write(" ");
            }
            for(int k=1;k<=i;k++)
            {
                System.Console.Write(count+" ");
                count++;
            }
            System.Console.WriteLine();
        }
    }
}