using System;
namespace ArithmeticOperations;
class Program 
{
    public static void Main(string[] args)
    {
        
           
            System.Console.WriteLine("Enter the number1: ");
            int number1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the number2: ");
            int number2=int.Parse(Console.ReadLine());
                    System.Console.WriteLine("Sum = "+Addition(number1,number2));
                    int Addition(int num1,int num2)
                    {
                        return num1+num2;
                    }
                    
               
                    System.Console.WriteLine("Difference = "+Subraction(number1,number2));
                    int Subraction(int num1,int num2)
                    {
                        return num1-num2;
                    }
                    
               
               
                    System.Console.WriteLine("Product = "+Multiplication(number1,number2));
                    int Multiplication(int num1,int num2)
                    {
                        return num1*num2;
                    }
               
                    System.Console.WriteLine("Quotient = "+Division(number1,number2));
                    int Division(int num1,int num2)
                    {
                        return num1/num2;
                    }
               
            
    }
}
