using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej08_EST36
    {
        public static void Ejecutar(string[] args)
        {
            int i = 1;
            int pares = 0;
            int impares = 0;
            do
            {
                Console.Write($"Artículo ({i}/5): ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Mañana (Par)");
                    pares++;
                }
                else
                {
                    Console.WriteLine("Tarde (Impar)");
                    impares++;
                }
                i++;
            }
            while (i <= 5);
            Console.WriteLine($"Pares: {pares}, Impares: {impares}");
        }
    }
}
