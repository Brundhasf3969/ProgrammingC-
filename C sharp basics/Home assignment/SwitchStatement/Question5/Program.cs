using System;
namespace CricketPlayers;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the country: ");
        string country=Console.ReadLine().ToUpper();
        switch(country)
        {
            case "INDIA":
            {
                System.Console.WriteLine("1. Dhoni\n2. Sachin\n3. Ashwin\n4. Yuvaraj");
                break;
            }
            case "PAKISHTAN":
            {
                System.Console.WriteLine("1. Imran Khan\n2. Mohammad\n3. Shahid\n4. Anwar");
                break;
            }
            case "BANGLADESH":
            {
                System.Console.WriteLine("1. Shakib AI Hasan\n2. Mohammad Ashraful\n3. Rahim\n4. Tammim Iqbal");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid");
                break;
            }
        }
    }
}
