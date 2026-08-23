
namespace proyecto_cs
{

    class Program
    {
        static void Main()
        {

            int[] enteros = [3, 4, 76, 4, 23, 35, 65, 66, 87, 23];

            int x = 35;
            bool fueEncontrado = false;
            int indice = 0;

            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] == x)
                {
                    fueEncontrado = true;
                    indice = i;
                }
            }

            if (fueEncontrado)
            {
                Console.WriteLine($"El numero {x} fue encontrado en el indice {indice}");
            }
            else
            {
                Console.WriteLine($"No se encontro el numero {x}");
            }
        }
    }

}

