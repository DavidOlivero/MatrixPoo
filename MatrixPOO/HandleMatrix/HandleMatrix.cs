using System;

namespace MatrixPOO.HandleMatrix;

public class HandleMatrix(double[,] matrix)
{
    private double[,] _matrix = matrix;

    public void PrintMatrix()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            Console.WriteLine("------------------------");
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write($"|{_matrix[i, j]}|");
            }
        }
    }
}