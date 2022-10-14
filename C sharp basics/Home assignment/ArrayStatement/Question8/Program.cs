using System;
namespace SumOfMatrix;
class Program 
{
    public static void Main(string[] args)
    {
        int[,] matrix1=new int[5,5];
        int[,] matrix2=new int[5,5];
        int[,] matrix3=new int[5,5];
        System.Console.WriteLine("Enter the size of matrix1 (less than 5): ");
        int size=int.Parse(Console.ReadLine());
        for(int i=0;i<size;i++)
        {
            for(int j=0;j<size;j++)
            {
                System.Console.Write("matrix1[{0}][{1}] = ",i,j);
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Enter the size of matrix2 (less than 5): ");
        int size1=int.Parse(Console.ReadLine());
        for(int i=0;i<size1;i++)
        {
            for(int j=0;j<size1;j++)
            {
                System.Console.Write("matrix2[{0}][{1}] = ",i,j);
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        if(size==size1)
        {
            
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    matrix3[i,j]=matrix1[i,j]+matrix2[i,j];
                }
            }

            System.Console.WriteLine("Addition of two matrixes :");
            for(int i=0;i<size;i++)
            {
                System.Console.WriteLine();
                for(int j=0;j<size;j++)
                {
                    System.Console.Write(matrix3[i,j]+" ");
                }
                
            }
            System.Console.WriteLine();
        }
    }
}
