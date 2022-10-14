using System;
namespace Array;
class Program 
{
    public static void Main(string[] args)
    {
        string[] name=new string[5];
        name[0]="Brundha";
        name[1]="Aarthi";
        name[2]="Divya";
        name[3]="Swetha";
        name[4]="Sneha";
        for(int i=0;i<name.Length;i++)
        {
            System.Console.WriteLine(name[i]);
        }
        
        System.Console.WriteLine("Enter the name:");
        string name1=Console.ReadLine();
        int temp=0;
        System.Console.WriteLine("Using for loop:");
        for(int i=0;i<name.Length;i++)
        {
            if(name[i]==name1)
            {
                System.Console.WriteLine("The name is present in the array. \nIndex value of the name is "+i);
                temp=1;
                break;
            }
        }
        if(temp==0)
        {
            System.Console.WriteLine("The name is not present in the array.");
        }
        System.Console.WriteLine("Using foreach loop:");
        int count=0;
        foreach(string name2 in name)
        {
            if(name2==name1)
            {
                System.Console.WriteLine("The name is present in the array.");
                count=1;
            }
        }
        if(count==0)
        {
            System.Console.WriteLine("The name is not present in the array.");
        }
        

        


    }
}
