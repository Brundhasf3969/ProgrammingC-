using System;
namespace Circle;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius of the circle: ");
        float radius=float.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the choice: \n1. Area\n2. Perimeter\n3. Diameter");
        string choice=Console.ReadLine().ToUpper();
        switch(choice)
        {
            case "AREA":
            {
                System.Console.WriteLine("Area of the circlr is "+(3.14*radius*radius));
                break;
            }
            case "PERIMETER":
            {
                System.Console.WriteLine("Perimeter of the circle is "+(2*3.14*radius));
                break;
            }
            case "DIAMETER":
            {
                System.Console.WriteLine("Diameter of the circle is "+(2*radius));
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}
