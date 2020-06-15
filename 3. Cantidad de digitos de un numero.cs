using System;

namespace Cantidad_de_digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 3
            //Crear un programa que me diga la cantidad de digitos que tiene un numero positivo.
            //Mostrar en mensaje ej: El numero ingresado tiene (N) digitos.

            int num;
            int i = 0;
            int user;

            Console.Write("Introduzca un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                num = num * -1;
            }

            user = num;

            while (num != 0)
            {
                i++;
                num = num / 10;

            }

            Console.WriteLine($"El numero {user} tiene {i} digitos.");

        }
    }
}
