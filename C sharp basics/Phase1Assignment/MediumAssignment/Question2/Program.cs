using System;
namespace FibonacciSeriesNumber;
class Program 
{
    public static void Main(string[] args)
    {
        
        FibonacciSeries();
        void FibonacciSeries()
        {
            System.Console.WriteLine("Enter the number of terms : ");
            int term=int.Parse(Console.ReadLine());
            int firstVal=0,lastVal=0,nextVal=1;
            System.Console.WriteLine("Fibonacci series : ");
            for(int i=0;i<term;i++)
            {
                if(i==0 || i==1)
                {
                    System.Console.Write(i+" ");
                }
                else
                {
                    firstVal=lastVal;
                    lastVal=nextVal;
                    nextVal=firstVal+lastVal;
                    System.Console.Write(nextVal+" ");
                }
            }


        }
    }
}
