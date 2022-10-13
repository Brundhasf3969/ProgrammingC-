using System;
namespace AdmissionEligibility;
class program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the physics marks: ");
        int physics=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the chemistry marks: ");
        int chemistry=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the maths marks: ");
        int Maths=int.Parse(Console.ReadLine());
        int sum=physics+chemistry+Maths;
        float percent=(float)sum/300*100;
        if(percent>=75 && percent<=100)
        {
            System.Console.WriteLine("The candidate is eligible for admission.");

        }
        else
        {
             System.Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
