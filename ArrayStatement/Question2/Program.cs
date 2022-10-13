using System;
namespace ReverseOrder;
class Program 
{
    public static void Main(string[] args)
    {
        int[] numbers=new int[3];
        numbers[0]=3;
        numbers[1]=7;
        numbers[2]=5;
        for(int i=numbers.Length-1;i>=0;i--)
        {
            System.Console.WriteLine(numbers[i]);
        }    
    }
}
