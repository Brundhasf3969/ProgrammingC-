using System;
namespace Arithmetic;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number1: ");
        int number1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number2: ");
        int number2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("{0}+{1}={2}",number1,number2,number1+number2);
        System.Console.WriteLine("{0}-{1}={2}",number1,number2,number1-number2);
        System.Console.WriteLine("{0}*{1}={2}",number1,number2,number1*number2);
        System.Console.WriteLine("{0}/{1}={2}",number1,number2,number1/number2);
        System.Console.WriteLine("{0}%{1}={2}",number1,number2,number1%number2);
    }
}