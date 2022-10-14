using System;
namespace ArithmeticCalculation;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number 1: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number 2: ");
        int num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the choice: ( \n +\n -\n *\n /)");
        char choice=char.Parse(Console.ReadLine());
        switch(choice)
        {
            case '+':
            {
                System.Console.WriteLine("Addition= "+(num1+num2));
                break;
            }
            case '-':
            {
                System.Console.WriteLine("Addition= "+(num1-num2));
                break;
            }
            case '*':
            {
                System.Console.WriteLine("Addition= "+(num1*num2));
                break;
            }
            case '/':
            {
                System.Console.WriteLine("Addition= "+(num1/num2));
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
