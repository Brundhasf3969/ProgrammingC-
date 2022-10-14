using System;
namespace TransposeMatrix;
class Program 
{
    public static void Main(string[] args)
    {
        int[,] matrix=new int[50,50];
        int[,] transpose=new int[50,50];
        System.Console.WriteLine("Enter the number of rows for matrix : ");
        int row=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of columns for matrix : ");
        int col=int.Parse(Console.ReadLine());
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                System.Console.Write("matrix1[{0}][{1}] = ",i,j);
                matrix[i,j]=int.Parse(Console.ReadLine());
            }
        }
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                transpose[j,i]=matrix[i,j];
            }
        }
        System.Console.WriteLine("Transpose matrix : ");
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                System.Console.Write(transpose[i,j]+" ");
            }
            System.Console.WriteLine();
        }
        
    }
}