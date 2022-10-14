using System;
namespace Numbers;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms: ");
        int numberOfTerms=int.Parse(Console.ReadLine());
        int i=1,sum=0;
        while(i<=numberOfTerms)
        {
            System.Console.WriteLine(i);
            sum+=i*i;
            i++;
        }
        System.Console.WriteLine("Output = "+sum);
    }
}
