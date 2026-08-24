
using System.Diagnostics.CodeAnalysis;

namespace proyecto_cs
{

    class Program
    {
        static void Main()
        {

            int[][] matriz = [
                [1,2,3],
                [4,5,6],
                [7,8,9]
            ];

            int suma = 0;

            for (int y = 0; y < matriz[0].Length; y++)
            {
                for (int x = 0; x < matriz.Length; x++)
                {
                    suma += matriz[x][y];
                }
            }

            Console.WriteLine(suma);
        }
    }

}

