using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MatrixTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for the dimensions of the two matrices: ");
            int n = int.Parse(Console.ReadLine());

            Matrix<int> firstMatrix = new Matrix<int>(n, n);
            Matrix<int> secondMatrix = new Matrix<int>(n, n);

            int inputFirstMatrix;
            int inputSecondMatrix;
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int column = 0; column < firstMatrix.Columns; column++)
                {
                    Console.Write("matrix1[{0},{1}] = ", row, column);
                    inputFirstMatrix = int.Parse(Console.ReadLine());
                    firstMatrix[row, column] = inputFirstMatrix;
                }
            }

            for (int row = 0; row < secondMatrix.Rows; row++)
            {
                for (int column = 0; column < secondMatrix.Columns; column++)
                {
                    Console.Write("matrix2[{0},{1}] = ", row, column);
                    inputSecondMatrix = int.Parse(Console.ReadLine());
                    secondMatrix[row, column] = inputSecondMatrix;
                }
            }

            Matrix<int> sum = firstMatrix + secondMatrix;
            Console.WriteLine("Addition Matrix: ");
            Console.WriteLine(sum.ToString());

            Matrix<int> subtract = firstMatrix - secondMatrix;
            Console.WriteLine("Subtraction Matrix: ");
            Console.WriteLine(subtract.ToString());

            Matrix<int> multiply = firstMatrix * secondMatrix;
            Console.WriteLine("Multiplication Matrix: ");
            Console.WriteLine(multiply.ToString());
        }
    }
}
