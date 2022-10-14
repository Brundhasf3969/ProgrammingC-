using System;
namespace String;
class Program 
{
    public static void Main(string[] args)
    {
        string str1="";
        string str2="";
        System.Console.WriteLine("Enter the long main string: ");
        str1=Console.ReadLine();
        System.Console.WriteLine("Enter the shortest substring from main string:  ");
        str2=Console.ReadLine();
        string[] splitString=str1.Split(new string[] {str2},StringSplitOptions.None);
        int count=splitString.Length-1;
        System.Console.WriteLine("String searched count is "+count);
    }
}
