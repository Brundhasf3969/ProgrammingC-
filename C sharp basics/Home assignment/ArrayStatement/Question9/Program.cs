using System;
namespace SumOfMatrix;
class Program 
{
    public static void Main(string[] args)
    {
        
        int[,] matrix1=new int[50,50];
        int[,] matrix2=new int[50,50];
        int[,] matrix3=new int[50,50];
        System.Console.WriteLine("Enter the number of rows for matrix1 : ");
        int row=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of columns for matrix1 : ");
        int col=int.Parse(Console.ReadLine());
        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                System.Console.Write("matrix1[{0}][{1}] = ",i,j);
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Enter the number of rows for matrix2 : ");
        int row1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the number of columns for matrix2 : ");
        int col1=int.Parse(Console.ReadLine());
        for(int i=0;i<row1;i++)
        {
            for(int j=0;j<col1;j++)
            {
                System.Console.Write("matrix2[{0}][{1}] = ",i,j);
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        if(col==row1)
        {
            
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col1;j++)
                {
                    for(int k=0;k<col;k++)
                    {
                        matrix3[i,j]+=matrix1[i,k]*matrix2[k,j];
                    }
                }
            }

            System.Console.WriteLine("Multiplication of two matrixes :");
            for(int i=0;i<row;i++)
            {
                
                for(int j=0;j<col1;j++)
                {
                    System.Console.Write(matrix3[i,j]+" ");
                }
                
            }
            System.Console.WriteLine();
        }
    }
}

