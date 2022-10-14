using System;
namespace ElementsStore;
class Program 
{
    public static void Main(string[] args)
    {
        int[] numbers=new int[10];
        numbers[0]=1;
        numbers[1]=2;
        numbers[2]=3;
        numbers[3]=4;
        numbers[4]=5;
        numbers[5]=6;
        numbers[6]=7;
        numbers[7]=8;
        numbers[8]=9;
        numbers[9]=10;
        for(int i=0;i<=numbers.Length;i++)
        {
            System.Console.WriteLine(numbers[i]);
        }
    }
}
