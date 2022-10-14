using System;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Mark :");
        int mark= int.Parse(Console.ReadLine());
        
        if (mark>=81 && mark<=100)
        {
            System.Console.WriteLine("Grade A");
        }
        else if(mark>=61 && mark<=80)
        {
            System.Console.WriteLine("Grade B");
        }
        else if(mark>=36 && mark<=60)
        {
            System.Console.WriteLine("Grade C");
        }
        else if(mark<=35 && mark>0)
        {
            System.Console.WriteLine("Grade D");
        }
        
        else
        {
           System.Console.WriteLine("Invalid Input");
        }
}
}
