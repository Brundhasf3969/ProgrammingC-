using System;
namespace OddEvenNumber;
class Program 
{
    public static void Main(string[] args)
    {
        string condition;
        do
        {
            System.Console.WriteLine("Enter the number: ");
            int number=int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                System.Console.WriteLine("Given number is even.");
            }
            else
            {
                System.Console.WriteLine("Given number is odd.");
            }
            System.Console.WriteLine("Do you want to continue again: (yes/no) ");
            condition=Console.ReadLine();
            
        }while(condition =="yes");
    }
}