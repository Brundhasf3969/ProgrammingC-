using System;
namespace ArmstrongNumber;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        int i=0,count=0,reminder=0;
        int number1=number;
        double sum=0;
        for(i=0; number1!=0 || i==0; i++)
        {
            reminder=number1%10;
            number1/=10;
            count++;
        }
        number1=number;
        
        for(i=0;reminder!=0 || i==0 ;i++)
        {
            reminder=number1%10;
            sum +=Math.Pow(reminder,count);
            number1 /=10;
        }
        if(sum==number)
        {
            System.Console.WriteLine("{0} is an Armstrong number.",number);
        }
        else
        {
            System.Console.WriteLine("{0} is not an Armstrong number.",number);
        }

    }
}