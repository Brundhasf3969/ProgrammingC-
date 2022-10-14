using System;
namespace MarksOfStudent;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Physics marks :");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Chemistry marks :");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Maths marks :");
        int maths=int.Parse(Console.ReadLine());
        int sum=physics+chemistry+maths;
        float percent=((float)sum/300)*100;
        System.Console.WriteLine("Sum ="+sum);
        System.Console.WriteLine("Percentage ="+percent+"%");
    }
}
