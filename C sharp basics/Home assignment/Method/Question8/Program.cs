using System;
namespace MethodQuestion8;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Mark1 : ");
        int mark1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Mark2 : ");
        int mark2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Mark3 : ");
        int mark3=int.Parse(Console.ReadLine());
        System.Console.WriteLine(mark1);
        System.Console.WriteLine(mark2);
        System.Console.WriteLine(mark3);
        System.Console.WriteLine("Percentage = "+Percent(mark1,mark2,mark3));
        
                int Percent(int num1,int num2,int num3)
        {
            int total,percent;
            total=num1+num2+num3;
            percent=total/3;
            return percent;
        }
    }
}
