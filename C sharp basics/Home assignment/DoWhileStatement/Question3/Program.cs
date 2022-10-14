using System;
namespace FibanocciSeries;
class Program 
{
    public static void Main(string[] args)
    {
        int i=0,firstVal=0,lastVal=0,nextVal=1;
        System.Console.WriteLine("Enter the number of terms: ");
        int numberTerms=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Fibanocci Series: ");
        do
        {
            if(i==0 || i==1)
            {
                System.Console.WriteLine(i);
            }
            else
            {
                firstVal=lastVal;
                lastVal=nextVal;
                nextVal=firstVal+lastVal;
                System.Console.WriteLine(nextVal);
            }
            i++;
        }while(i>=0 && numberTerms>i);
    }
}
