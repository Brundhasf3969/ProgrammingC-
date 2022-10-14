using System;
namespace IntegerCheck;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number: ");
        int number=int.Parse(Console.ReadLine());
        if(number<100)
        {
            System.Console.WriteLine("{0} is less than 100",number);
        }
        else if(number>=100 && number<=200)
        {
            System.Console.WriteLine("{0} is between 100 and 200",number);
        }
        else
        {
            System.Console.WriteLine("{0} is greater than 200",number);
        }
    }
}
