using System;

namespace Tabla_de_multiplicar_del_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //Crear una aplicacion que muestre la tabla de multiplicar del (7).
            //Usando bucle while

            int i = 0;

            while (i != 13)
            {
                Console.WriteLine($"7 X {i} es igual a: " + 7 * i);
                i++;
            }
        }
    }
}
