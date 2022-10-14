using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string str=Console.ReadLine();
        int temp;
        for(int i=0;i<str.Length;i++)
        {

            if(str[i]>='0' && str[i]<='9')
            {
                temp.Add(str[i]);
            }
        }
    }
}
