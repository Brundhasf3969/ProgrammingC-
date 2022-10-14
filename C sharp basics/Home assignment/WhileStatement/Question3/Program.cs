using System;
namespace FibonacciSeries;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms: ");
        int terms=int.Parse(Console.ReadLine());
        int i=0,firstVal=0,nextVal=1,lastVal=0;
        System.Console.WriteLine("Fibonacci series :");
        while(i>=0 && i<terms)
        {
            if(i==0 || i==1)
            {
                System.Console.WriteLine(i);
                
            }
            else
            {
                firstVal=lastVal;
                lastVal=nextVal;
                nextVal=firstVal+lastVal;   
                System.Console.WriteLine(nextVal);
            }
            
            i++;
        }
    }
}
