using System;
namespace Switch;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the num1:");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the num2: ");
        int num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the choice: (+ /- /* /% / /)");
        char choice=char.Parse(Console.ReadLine());
        switch(choice)
        {
            case '+':
                    {
                        System.Console.WriteLine("{0}+{1}={2}",num1,num2,num1+num2);
                        break;
                    }
            case '-':
                    {
                        System.Console.WriteLine("{0}-{1}={2}",num1,num2,num1-num2);
                        break;
                    }
            case '*':
                    {
                        System.Console.WriteLine("{0}*{1}={2}",num1,num2,num1*num2);
                        break;
                    }
            case '/':
                    {
                        System.Console.WriteLine("{0}/{1}={2}",num1,num2,num1/num2);
                        break;
                    }
            case '%':
                    {
                        System.Console.WriteLine("{0}%{1}={2}",num1,num2,num1%num2);
                        break;
                    }
            default:
                    {
                        System.Console.WriteLine("Invalid option");
                        break;
                    }
        }
    }
}
