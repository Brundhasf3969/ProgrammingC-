using System;
namespace OddEvenPrime;
class Program 
{
    public static void Main(string[] args)
    {
        int number=1;
        System.Console.WriteLine("Even numbers: ");
        while(number<=10)
        {
            
            if(number%2==0)
            {
                System.Console.WriteLine(number);
            }
            number++;
        }
        
        System.Console.WriteLine("Odd numbers: ");
        int number1=1;
        while(number1<=10) 
        {   
            if(number1%2!=0) 
            {
                System.Console.WriteLine(number1);
            }
            number1++;
        }
        int i,j;
        System.Console.WriteLine("Prime numbers: ");
            for(i=2;i<=10;i++)
            {
                int count=0;
                for(j=1;j<=i/2;j++)
                {
                if(i%j==0)
                {
                    count=1;;
                }
                
                }
               if(count==0 )
                {
                    System.Console.WriteLine(i);
                }
                
                j=1;
            }
        
        
        
    }
}
