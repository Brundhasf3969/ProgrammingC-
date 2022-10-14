using System;
namespace Season;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month: ");
        string month=Console.ReadLine().ToLower();
        if(month=="december" || month=="january" || month=="february")
        {
           System.Console.WriteLine("It is a Winter");
        }
        else if(month=="march" || month=="april" || month=="may")
        {
            System.Console.WriteLine("It is a Spring");
        }
        else if(month=="june" || month=="july" || month=="auguest")
        {
            System.Console.WriteLine("It is a Summer");
        }
        else if(month=="september" || month=="october" || month=="november")
        {
            System.Console.WriteLine("It is a Rainfall");
        }
        else
        {
            System.Console.WriteLine("Invaild input");
        }
    }
}