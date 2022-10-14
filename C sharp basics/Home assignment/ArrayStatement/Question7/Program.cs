using System;
namespace Matrix;
class Program 
{
    public static void Main(string[] args)
    {
        int[,] matrix=new int[3,3];
        int j; 
        for(int i=0;i<3;i++)
        {
            for(j=0;j<3;j++)
            {
                System.Console.Write("matrix[{0}][{1}] = ",i,j);
                matrix[i,j]=int.Parse(Console.ReadLine());
                
            }
        }
        for(int i=0;i<3;i++)
        {
            System.Console.WriteLine();
            for(j=0;j<3;j++)
            {
                
                System.Console.Write(matrix[i,j]+" ");
            }
        }
        System.Console.WriteLine();
        
    }
}
