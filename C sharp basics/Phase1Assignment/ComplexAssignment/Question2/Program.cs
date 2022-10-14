using System;
namespace TailorSeries;
class Program 
{
    public static void Main(string[] args)
    {
        int i;
        double answer=1;
        for(i=1;i<=8;i++)
        {
            answer=answer+((double)Power(i) /(int)Fact1(i));
            
            
            
           
        }
        System.Console.WriteLine(answer);

        int Power(int num)
        {
            int power=1;
            for(int k=1;num>=k;k++)
            {
                power*=2;
            }
            return power;
        }
        int Fact1(int number)
        {
            int facto=1;
            for(int j=1;number>=j;j++)
            {
                facto*=j;
                
            }
            return facto;
        } 
    }
}