using System;
namespace SalaryCalculation;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month: (january to december):");
        string month=Console.ReadLine().ToLower();
        System.Console.WriteLine("How many days did you take leave:");
        int leave=int.Parse(Console.ReadLine());
        int workingdays,salary;
        switch(month)
        {
            case "january":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "febuary":
            {
                workingdays=28-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "march":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "april":
            {
                workingdays=30-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "may":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "june":
            {
                workingdays=30-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "july":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "auguest":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "september":
            {
                workingdays=30-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "october":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "november":
            {
                workingdays=30-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            case "december":
            {
                workingdays=31-leave;
                salary=workingdays*500;
                System.Console.WriteLine("Salary of the {0} is {1}",month,salary);
                break;
            }
            
        }
    }
}