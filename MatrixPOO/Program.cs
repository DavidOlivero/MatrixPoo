namespace MatrixPOO
{
    internal abstract class Program
    {
        public static void Main()
        {
            MakeMatrix.MakeMatrix matrix = new();
            HandleMatrix.HandleMatrix handleMatrix = new(matrix.GetMatrix());
            
            handleMatrix.PrintMatrix();
        }
    }
}