using System;

namespace Generar_numero_aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ejercicio 4
            Crear una aplicacion que genere un numero aleatorio entre 50 y 100.
            Y pida al usuario si desea generar otro numero antes de terminar la aplicacion.
            El programa debe terminar cuando el usuario presione la letra 's' 
            */

            //Creating a ramdom instance

            Random aleatory = new Random();
            int num;

            //Generating ramdom number

           // num = aleatory.Next(50, 101);
           // Console.WriteLine(num);

            //Preguntando si quiere generar numero aleatorio

            Console.Write("Presione enter. Para generar numero aleatorio: ");
            string answer = Console.ReadLine().ToLower();

            num = aleatory.Next(50, 101);
            Console.WriteLine(num);

            //Terminando programa

            Console.Write("Quiere generar otro numero, antes de que termine la aplicacion? Si = (s) , No = (otra tecla): ");
            answer = Console.ReadLine().ToLower();

            if (answer.Equals("s"))
            {
                num = aleatory.Next(50, 101);
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("El programa termino.");
            }

        }
    }
}
