using System;
namespace SumAverage;
class Program 
{
    public static void Main(string[] args)
    {
        int i,count=0,sum=0;
        for(i=1;i<=10;i++)
        {
            sum+=i;
            count++;
        }
        float average=(float)sum/count;
        System.Console.WriteLine("Sum= "+sum);
        System.Console.WriteLine("Average= "+average);
    }
}
