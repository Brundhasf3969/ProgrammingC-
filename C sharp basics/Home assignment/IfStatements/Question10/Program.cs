using System;
namespace PasswordCheck;
class Program 
{
    public static void Main(string[] args)
    {
        string defaultPassword="HiTeam";
        System.Console.WriteLine("Enter the password: ");
        string correctPassword=Console.ReadLine();
        if(defaultPassword==correctPassword)
        {
            System.Console.WriteLine("Right password");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
    }
}