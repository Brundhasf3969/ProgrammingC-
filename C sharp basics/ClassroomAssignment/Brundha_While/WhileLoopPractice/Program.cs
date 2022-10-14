using System;
namespace WhileLoop;
class Program 
{
    public static void Main(string[] args)
    {
        int i=0;
        while(i>=0 && i<=25)
        {
            if(i%2==0)
            {
                System.Console.WriteLine(i);
            }    
        i++;
        }
    }
}