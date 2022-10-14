using System;
namespace LeapYear;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range : ");
        int range=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Leap year between 1 to {0} :",range);
        for(int i=4;i<=range;i++)
        {
            if(i%4==0)
            {
                System.Console.Write(i+" ");
            }
        }
    }
}

