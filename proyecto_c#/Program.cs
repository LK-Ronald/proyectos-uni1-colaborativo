
namespace proyecto_cs
{

    class Program
    {
        static void Main()
        {

            int[] enteros = [3, 4, 76, 4, 23, 35, 65, 66, 87, 23];

            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] % 2 != 0)
                {
                    enteros[i] = 0;
                }
            }

            foreach (int i in enteros) { Console.WriteLine(i); }
        }
    }

}

