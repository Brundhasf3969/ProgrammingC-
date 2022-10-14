using System;
namespace Salary;
class Program 
{
    public static void Main(string[] args)
    {
        float basicSalary=10000,actualSalary,annualSalary,finalSalary;
        float da=10000*10/100;
        float hra=10000*10/100;
        actualSalary=basicSalary+da+hra;
        annualSalary=12*actualSalary;
        float tax=annualSalary*5/100;
        finalSalary=annualSalary-tax;
        System.Console.WriteLine("His annual salary is "+finalSalary);
    }
}