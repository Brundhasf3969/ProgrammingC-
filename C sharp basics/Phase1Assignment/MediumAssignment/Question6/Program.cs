using System;
namespace MatrixAddition;
class Program 
{
    public static void Main(string[] args)
    {
        int[,] matrix1=new int[3,3];
        int[,] matrix2=new int[3,3];
        int[,] matrix3=new int[3,3];
         System.Console.WriteLine("Matrix1 :");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
               
                System.Console.Write("Matrix1[{0}] [{1}] = ",i,j);
                matrix1[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Matrix2 :");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                
                System.Console.Write("Matrix2[{0}] [{1}] = ",i,j);
                matrix2[i,j]=int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("Matrix1 :");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                matrix3[i,j]=matrix1[i,j]+matrix1[i,j];
                
            }
        }
        
        System.Console.WriteLine();
        System.Console.WriteLine("Addition of two matrix is : ");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                
                System.Console.Write(matrix3[i,j]+" ");
            }
            System.Console.WriteLine();
        }
    }
}
