using System;
namespace FibonacciSequence;
class Program 
{
    public static void Main(string[] args)
    {
        FibonacciSeries();
        void FibonacciSeries()
        {
            System.Console.WriteLine("Enter the number of terms : ");
            int numberOfTerms=int.Parse(Console.ReadLine());
            int firstVal=0,lastVal=0,nextVal=1;
            for(int i=0;i<5;i++)
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
               
            }

            
        }
    }
}
