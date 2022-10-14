using System;
namespace TrianglePattern;
class Program 
{
    public static void Main(string[] args)
    {
        for(int row=1;row<=6;row++)
        {
            for(int col=1;col<=row;col++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
        
    }
}
