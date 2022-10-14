using System;
namespace SumOfSquareOfValues;
class Program 
{
    public static void Main(string[] args)
    {
        int sum=0;
        for(int i=1;i<100;i++)
        {
            if(i%2!=0)
            {
                sum+=i*i;
            }
        }
        System.Console.WriteLine("Sum of square of the number in 1 to 99 is "+sum);
    }
}
