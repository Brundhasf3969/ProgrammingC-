using System;
namespace ArmstrongNumber;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the lower limit : ");
        int lowerLimit=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the upper limit : ");
        int upperLimit=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Armstrong number are :");
        
        while(lowerLimit<=upperLimit)
        {
            int temp=lowerLimit;
            int count=0;
            for(int k=0;temp!=0;k++)
            {
                temp/=10;
                count++;
            }
            int reminder=0;
            double sum=0;
            temp=lowerLimit;
            for(int j=0;temp!=0 ; j++)
            {
                reminder=temp%10;
                sum+=Math.Pow((double)reminder,(double)count);
                temp/=10;
            }
            if(lowerLimit==sum)
            {
                System.Console.Write(lowerLimit+" ");
            }
            lowerLimit++;
        }   
    }
}