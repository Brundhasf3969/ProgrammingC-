using System;
namespace SumOfNumbersInArray;
class Program 
{
    public static void Main(string[] args)
    {
        int size;
        System.Console.WriteLine("Enter the array size : ");
        size=int.Parse(Console.ReadLine());
        int[] number=new int[size];
        int sum=0;
        for(int i=0;number.Length>i;i++)
        {
            System.Console.Write("number[{0}] = ",i);
            number[i]=int.Parse(Console.ReadLine());
            
        }
        foreach(int number1 in number)
        {
            sum+=number1;
        }
         System.Console.WriteLine("Sum of the array elements is {0} ",sum);
    }
}
