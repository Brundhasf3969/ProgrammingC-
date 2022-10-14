using System;
namespace MatrixMultiplication;
class program 
{
    public static void Main(string[] args)
    {
        int[,] matrix1=new int[2,3];
        int[,] matrix2=new int[3,2];
        int[,] matrix3=new int[3,3];
        matrix1[0,0]=1;
        matrix1[0,1]=2;
        matrix1[0,2]=3;
        matrix1[1,0]=4;
        matrix1[1,1]=5;
        matrix1[1,2]=6;
        matrix2[0,0]=7;
        matrix2[0,1]=8;
        matrix2[1,0]=9;
        matrix2[1,1]=10;
        matrix2[2,0]=11;
        matrix2[2,1]=12;
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
                for(int k=0;k<3;k++)
                {
                    matrix3[i,j]+=matrix1[i,k]*matrix2[k,j];
                }
            }
        }
        System.Console.WriteLine("Multiplication : ");
        for(int i=0;i<2;i++)
        {
            for(int j=0;j<2;j++)
            {
                
                System.Console.Write(matrix3[i,j]+" ");
            }
            System.Console.WriteLine();
        }
    }
}
