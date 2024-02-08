using System;

namespace MatrixPOO.MakeMatrix
{
    public class MakeMatrix
    {
        private readonly int _row = HandleInput.HandleInput.EvaluateNumber("Ingrese la longitud de la fila");
        private readonly int _column = HandleInput.HandleInput.EvaluateNumber("Ingrese la longitud de la columna");
        private readonly double[,] _matrix;

        public MakeMatrix()
        {
            this._matrix = new double[_row, _column];

            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    Console.Clear();
                    
                    _matrix[i, j] =
                        HandleInput.HandleInput.EvaluateNumber(
                            $"Ingrese el valor de la fila {i + 1} y columna {j + 1}");
                }
            }
        }

        public double[,] GetMatrix()
        {
            return _matrix;
        }
    }
}