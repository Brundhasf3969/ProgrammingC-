using System;
namespace Method;
class Program 
{
    public static void Main(string[] args)
    {
        string condition="null";
        do
        {
        
        System.Console.WriteLine("Choose the option: \n1. Addition \n2. Subraction \n3. Multiplication \n4. Division");
        int option=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number1: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number1: ");
        int num2=int.Parse(Console.ReadLine());
        
        switch(option)
        {
            case 1:
            {
                System.Console.WriteLine("The addition value is "+Addition(num1,num2));
                int Addition(int number1,int number2)
                {   
                    return num1+num2;
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("The difference value is "+Subraction(num1,num2));
                int Subraction(int number1,int number2)
                {   
                    return num1-num2;
                }
                break;
            }
            case 3:
            {
                System.Console.WriteLine("The product value is "+Multiplication(num1,num2));
                int Multiplication(int number1,int number2)
                {   
                    return num1*num2;
                }
                break;
            }
            case 4:
            {
                System.Console.WriteLine("The Quotient value is "+Division(num1,num2));
                int Division(int number1,int number2)
                {   
                    return num1/num2;
                }
                break;
            }
        }
        System.Console.WriteLine("Do you want to continue the process (yes/no): ");
        condition=Console.ReadLine();
        }while(condition=="yes");
    }
}
