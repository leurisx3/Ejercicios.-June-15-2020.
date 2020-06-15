using System;

namespace Primo_o_no._y_validar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2
            //Crear una aplicacion que le pida al usuario un numero positivo.
            //El sistema identificara si es primo o no.

            int num, primo;
            int i = 0;

            Console.Write("Introduzca un numero positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 2)
            {
                Console.WriteLine($"El numero {num} es primo");
                Environment.Exit(0);
            }

            while (num <= 0)
            {
                i++;
                Console.Write("El numero es negativo. Introduzca un numero positivo: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (i == 2)
                {
                    Console.WriteLine("El programa termino.");
                    Environment.Exit(0);
                }

            }

            primo = num % 2;

            if (primo != 0)
            {
                Console.WriteLine($"El numero {num} es primo");
            }
            else
            {
                Console.WriteLine($"El numero {num} no es primo");
            }
        }
    }
}
