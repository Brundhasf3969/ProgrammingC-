using System;
namespace Distance;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the speed of the vehicle = ");
        int speed=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the time,that the vehicle = ");
        int time=int.Parse(Console.ReadLine());
        float distance=(float)speed*time*5/18;
        System.Console.WriteLine("Distance = "+Math.Round(distance));
    }
}