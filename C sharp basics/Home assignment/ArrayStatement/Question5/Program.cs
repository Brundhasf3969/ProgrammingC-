using System;
namespace OddAndEven;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] numbers=new int[size];
        for(int i=0;size>i;i++)
        {
            System.Console.WriteLine("numbers[{0}]= ",i);
            numbers[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Even numbers: ");
        for(int j=0;size>j;j++)
        {
            if (numbers[j]%2==0)
            {
                System.Console.WriteLine(numbers[j]);
            }
        }
        System.Console.WriteLine("Odd numbers: ");
        for(int k=0;size>k;k++)
        {
            if(numbers[k]%2!=0)
            {
                System.Console.WriteLine(numbers[k]);
            }
        }

    }
}