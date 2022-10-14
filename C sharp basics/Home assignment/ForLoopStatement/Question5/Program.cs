using System;
namespace SumOfOddNumbers;
class Prgarm 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of the terms: ");
        int number=int.Parse(Console.ReadLine());
        int i,count=1,sum=0;
        for(i=1;count<=number;i++)
        {
            if(i%2!=0)
            {
                System.Console.WriteLine(i);
                sum+=i;
                count++;
            }
        }
        System.Console.WriteLine("Sum of th odd natural upto 10 terms: "+sum);
    }
}
