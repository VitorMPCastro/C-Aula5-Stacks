using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Aula5_Stacks
{
    internal class Matrix
    {  
        private int[,] matrix = new int[3, 3];

        public Matrix()
        {
            Console.WriteLine("Enter dimensions (height width):");
            string dimensions = Console.ReadLine();
            string[] dimensionParts = dimensions.Split(' ');
            int height = Convert.ToInt32(dimensionParts[0]);
            int width = Convert.ToInt32(dimensionParts[1]);
            matrix = new int[height, width];

            Console.WriteLine("Insert entire rows. i.e.: 1 2 3 4 5");
            for (int i = 0; i < height; i++)
            {
                string row = Console.ReadLine();
                string[] rowElements = row.Split(' ');
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = Convert.ToInt32(rowElements[j]);
                }
            }
        }

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            Random random = new();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(0, 99);
                }
            }
        }

        public void print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        public void Transpose()
        {
            int[,] transposedMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }
            matrix = transposedMatrix;
        }
    }
}
