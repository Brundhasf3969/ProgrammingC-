using System;
namespace MaxMin;
class Program 
{
    public static void Main(string[] args)
    {
        int i,temp,temp1;
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] number=new int[size];
        for(i=0;size>i;i++)
        {
            System.Console.WriteLine("number[{0}]= ",i);
            number[i]=int.Parse(Console.ReadLine());
        }
        temp=number[0];
        temp1=number[0];
        for(i=1;size>i;i++)
        {
            if(temp<number[i])
            {
                temp=number[i];
            }
            if(temp1>number[i])
            {
                temp1=number[i];
            }
        }
        System.Console.WriteLine("Maximum value of the array is "+temp);
        System.Console.WriteLine("Minimum value of the array is "+temp1);
    }
}
