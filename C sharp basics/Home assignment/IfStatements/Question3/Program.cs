using System;
namespace LeapYear;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the year: ");
        int year=int.Parse(Console.ReadLine());
        if(year%4==0)
        {
            System.Console.WriteLine("{0} is the Leap Year",year);
        }
        else
        {
            System.Console.WriteLine("{0} is not Leap Year",year);
        }
    }
}
