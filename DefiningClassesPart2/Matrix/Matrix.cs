using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set
            {
                if (value > 0)
                {
                    this.rows = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Rows must be more than 0");
                }
            }
        }
        public int Columns
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value > 0)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Columns must be more than 0");
                }
            }
        }
        public T this[int indexOfRows, int indexOfCols]
        {
            get
            {
                if (indexOfRows > this.Rows - 1 || indexOfRows < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", indexOfRows));
                }

                if (indexOfCols > this.Columns - 1 || indexOfCols < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", indexOfCols));
                }
                T result = this.matrix[indexOfRows, indexOfCols];
                return result;
            }

            set { this.matrix[indexOfRows, indexOfCols] = value; }
        }
        
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Columns != second.Columns || first.Rows != second.Rows)
            {
                throw new Exception("The Matrices are with different dimensions.");
            }
            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }
            return result;
        }
        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Columns != second.Columns || first.Rows != second.Rows)
            {
                throw new Exception("The Matrices are with different dimensions.");
            }
            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Columns != second.Columns || first.Rows != second.Rows)
            {
                throw new Exception("The Matrices are with different dimensions.");
            }
            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);
            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] * second[row, col];
                }
            }
            return result;
        }
        public override string ToString()
        {
            string result = null;
            for (int row = 0; row < this.Rows; row++)
            {
                for (int column = 0; column < this.Columns; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
            return result;
        }
        private static bool CheckValue(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            return CheckValue(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return CheckValue(matrix);
        }

    }
}
