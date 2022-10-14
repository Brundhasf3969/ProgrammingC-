using System;
namespace VowelOrConsonant;
class Program 
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the alphabet (a to z): ");
        char alphabet=char.Parse(Console.ReadLine().ToLower());
        switch(alphabet)
        {
            case 'a':
            {
                System.Console.WriteLine("{0} is the vowel.",alphabet);
                break;
            }
            case 'e':
            {
                System.Console.WriteLine("{0} is the vowel.",alphabet);
                break;
            }
            case 'i':
            {
                System.Console.WriteLine("{0} is the vowel.",alphabet);
                break;
            }
            case 'o':
            {
                System.Console.WriteLine("{0} is the vowel.",alphabet);
                break;
            }
            case 'u':
            {
                System.Console.WriteLine("{0} is the vowel.",alphabet);
                break;
            }
            default:
            {
                System.Console.WriteLine("{0} is not vowel.",alphabet);
                break;
            }
        }

    }
}
