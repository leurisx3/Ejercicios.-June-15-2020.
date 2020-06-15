using System;

namespace Cantidad_de_ceros_entre_1_y_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 5
            //Crear una aplicacion que muestre la cantidad de ceros que hay entre 1 y 100

            int num = 100;
            int a = 1;
            int i = 0;

            while(num >= a)
            {
                Console.WriteLine(num);
                if (100 % 10 == 0)
                {
                    i++;
                }

                num -= 10;
            }

            i++;
            Console.WriteLine($"Hay {i} ceros.");
        }
    }
}