using System;
namespace SalaryCalculation;
class Program 
{
    public static void Main(string[] args)
    {
        double hra,da,basicSalary,annualSalary,actualSalary,tax,insurance,monthlySalary;
        System.Console.WriteLine("Enter the salary : ");
        double salary=double.Parse(Console.ReadLine());
        if(salary<=10000 && salary>0)
        {
            hra=salary*20/100;
            da=salary*80/100;
            basicSalary=salary+hra+da;
            annualSalary=12*basicSalary;
            tax=annualSalary*6/100;
            insurance=annualSalary*1/100;
            actualSalary=annualSalary-tax-insurance;
            monthlySalary=actualSalary/12;
            System.Console.WriteLine("Annual salary is "+annualSalary +"\nAnnual take home salary  "+actualSalary +"\nMonthly take home salary is "+monthlySalary);
        }
        else if(salary<=20000 && salary>10000)
        {
            hra=salary*25/100;
            da=salary*90/100;
            basicSalary=salary+hra+da;
            annualSalary=12*basicSalary;
            tax=annualSalary*6/100;
            insurance=annualSalary*1/100;
            actualSalary=annualSalary-tax-insurance;
            monthlySalary=actualSalary/12;
            System.Console.WriteLine("Annual salary is "+annualSalary +"\nAnnual take home salary  "+actualSalary +"\nMonthly take home salary is "+monthlySalary);
        }
        else if(salary>20000 )
        {
            hra=salary*30/100;
            da=salary*95/100;
            basicSalary=salary+hra+da;
            annualSalary=12*basicSalary;
            tax=annualSalary*6/100;
            insurance=annualSalary*1/100;
            actualSalary=annualSalary-tax-insurance;
            monthlySalary=actualSalary/12;
            System.Console.WriteLine("Annual salary is "+annualSalary +"\nAnnual take home salary  "+actualSalary +"\nMonthly take home salary is "+monthlySalary);
        }
        else
        {
            System.Console.WriteLine("Invalid input.");
        }
    }
}
