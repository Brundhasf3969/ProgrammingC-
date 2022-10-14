using System;
class Program 
{
    public static void Main(string[] args)
    {
        int age,subject1,subject2,subject3,total;
        System.Console.WriteLine("Trainee details are");
        System.Console.Write("Enter your name : ");
        string name= Console.ReadLine();
        System.Console.Write("Enter your age : ");
         age= Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter mark of the subject1 : ");
         subject1= Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter mark of the subject2 : ");
         subject2=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter mark of the subject3 : ");
         subject3= Convert.ToInt32(Console.ReadLine());
         total= subject1 + subject2 + subject3;
         float average =(float)total/3;
        System.Console.WriteLine("Enter Grade :");
         char grade= Convert.ToChar(Console.ReadLine());
        System.Console.WriteLine("Enter Mobile Number : ");
         long mobileNumber=Convert.ToInt64(Console.ReadLine());
        System.Console.WriteLine("Enter Mail id : ");
         string mailId= Console.ReadLine();
        System.Console.WriteLine("Enter CGPA : ");
         decimal cgpa=Convert.ToDecimal(Console.ReadLine());
         System.Console.WriteLine("Name:"+name);
         System.Console.WriteLine("Age:"+age);
         System.Console.WriteLine("Mobile number: "+mobileNumber);
         System.Console.WriteLine("Mark1: "+subject1);
         System.Console.WriteLine("Mark2: "+subject2);
         System.Console.WriteLine("Mark3: "+subject3);
         System.Console.WriteLine("Total = "+total);
         System.Console.WriteLine("Average = " +Math.Round(average,2));
         System.Console.WriteLine("Grade: "+grade);
         System.Console.WriteLine("Mail Id: "+mailId);
         System.Console.WriteLine("CGPA: "+cgpa);
    }
}