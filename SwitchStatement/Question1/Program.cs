using System;
namespace EquivalentDescription;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the statement: ");
        char statement=char.Parse(Console.ReadLine().ToUpper());
        switch(statement)
        {
            case 'E':
            {
                System.Console.WriteLine("Excellent");
                break;
            }
            case 'V':
            {
                System.Console.WriteLine("Very good");
                break;
            }
            case 'G':
            {
                System.Console.WriteLine("Average");
                break;
            }
            case 'F':
            {
                System.Console.WriteLine("Fail");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}