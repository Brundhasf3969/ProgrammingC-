using System;
namespace DateTimeType;
class Program 
{
    public static void Main(string[] args)
    {
        DateTime dateTime=new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine(dateTime.Year);
        System.Console.WriteLine(dateTime.Month);
        System.Console.WriteLine(dateTime.Day);
        System.Console.WriteLine(dateTime.Hour);
        System.Console.WriteLine(dateTime.Minute);
        System.Console.WriteLine(dateTime.Second);
        string str=dateTime.ToString("yyyy/MM/dd hh:mm:ss tt");
        string[] splitChar=str.Split(new char[]{ '/',' ',':' },StringSplitOptions.None);
        for(int i=splitChar.Length-1;i>=0;i--)
        {
            System.Console.Write(splitChar[i]+" ");
            
        }
        System.Console.WriteLine();
        Console.WriteLine("Enter your date of dd/MM/yyyy hh:mm:ss tt format");
        DateTime dateTime1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm:ss tt", null);
        System.Console.WriteLine(dateTime.Year);
        System.Console.WriteLine(dateTime.Month);
        System.Console.WriteLine(dateTime.Day);
    }
}
