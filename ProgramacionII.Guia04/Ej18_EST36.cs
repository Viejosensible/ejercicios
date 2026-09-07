using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej18_EST36
    {
        public static void Ejecutar(string[] args)
        {

            int total = 0, hitos = 0, i = 1;

            do
            {
                Console.Write($"Teleconsultas año {2020 + i}: ");
                total += Convert.ToInt32(Console.ReadLine());

                if (i % 5 == 0)
                {
                    Console.Write("¿Hubo acto? (1=Sí, 2=No): ");
                    int acto = Convert.ToInt32(Console.ReadLine());

                    if (acto == 1)
                    {
                        hitos++;
                        Console.WriteLine("Hito conmemorado");
                    }
                    else
                        Console.WriteLine("No hubo acto");
                }

                i++;
            }
            while (i <= 12);

            Console.WriteLine($"Total teleconsultas: {total}");
            Console.WriteLine($"Hitos conmemorados: {hitos}");

        }
    }
}