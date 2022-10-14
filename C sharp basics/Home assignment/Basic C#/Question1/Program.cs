using System;
namespace Helloname;
class program 
{
    public static void Main(string[] args)
    {
        string greetings= "Hello";
        string name = "Brundha";

        //Concatenation
        System.Console.WriteLine(greetings+" : "+name);

        //Place holder
        System.Console.WriteLine("{0} : {1}",greetings,name);

        //inter polation
        System.Console.WriteLine($"{greetings} : {name}");

    }
}
