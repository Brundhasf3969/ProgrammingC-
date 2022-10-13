using System;
namespace CubeOfNumbers;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        for(int i=1;number>=i;i++)
        {
            System.Console.WriteLine("Number is :{0} \nCube of the number is {1}",i,i*i*i);
        }
    }
}
