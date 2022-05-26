using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiply
{
    internal class MatrixMultiply
    {
        const byte k = 3;
        const byte m = 2;
        const byte n = 4;
        static void Main(string[] args)
        {
            int[,] a = new int[k, m];
            int[,] b = new int[m, n];
            int[,] result = new int[k, n];
            Input(ref a);
            Output(ref a);
            Input(ref b);
            Output(ref b);
            Multiply(ref a, ref b, ref result);
            Console.WriteLine("Result:");
            Output(ref result);
        }

        static void Input(ref int[,] M)
        {
            int length = M.GetLength(0);
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("Enter element ({0},{1}):", i+1, j+1);
                    M[i,j]=int.Parse(Console.ReadLine());
                }
            }
        }

        static void Output(ref int[,] M)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0}   ", M[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void Multiply(ref int[,] M, ref int[,] N, ref int[,] R)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < N.GetLength(1); j++)
                {
                    for (int r = 0; r < M.GetLength(1); r++)
                    {
                        R[i, j] = R[i, j]+M[i,r]*N[r,j];
                    }
                   
                }
 
            }
        }
    }
}
