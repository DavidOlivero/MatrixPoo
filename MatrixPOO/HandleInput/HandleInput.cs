using System;

namespace MatrixPOO.HandleInput
{
    public abstract class HandleInput
    {
        public static int EvaluateNumber(string message, bool isInt = true)
        {
            while (true)
            {
                Console.WriteLine(message);

                if (isInt)
                {
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        return number;
                    }
                }
                else
                {
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        return number;
                    }
                }
                
                Console.WriteLine("El valor ingresado no es correcto inténtelo de nuevo");
            }
        }
    }
}