using System;
namespace AssendingOrder;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array: ");
        int size=int.Parse(Console.ReadLine());
        int[] numbers=new int[size];
        for(int i=0;i<size;i++)
        {
            System.Console.WriteLine("number[{0}]= ",i);
            numbers[i]=int.Parse(Console.ReadLine());
        }
        int temp=0;
        for(int j=0;j<size;j++)
        {
            for(int k=j+1;k<size;k++)
            {
                if(numbers[j]>numbers[k])
                {
                    temp=numbers[j];
                    numbers[j]=numbers[k];
                    numbers[k]=temp;
                }
            }
        }
        System.Console.WriteLine("Ascending order : ");
        for(int i=0;i<size;i++)
        {
            System.Console.Write(numbers[i]);
        }
    }
}
