using System;
namespace SwapingNumbers;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number1 value: ");
        int num1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number2 value: ");
        int num2=int.Parse(Console.ReadLine());
        
        Swap(num1,num2);
        
        
        void Swap(int number1,int number2)
        {
            System.Console.WriteLine("Bfore swaping : \nNumber1= "+number1 +"\nNumber2= "+number2);
            int temp;
            temp=number1;
            number1=number2;
            number2=temp;
            System.Console.WriteLine("After swaping: \nNumber1= "+number1 +"\nNumber2= "+number2);

            
        }
    }
}
