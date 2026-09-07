using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej19_EST36
    {
        public static void Ejecutar(string[] args)
        {

            int recursos = 3, puntos = 0, opcion;

            do
            {
                Console.Write("1) Intensiva  2) Preventiva  3) Retirarse: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    puntos += 150;
                    recursos--;

                    if (recursos == 1)
                        Console.WriteLine("¡Queda un solo recurso!");
                }
                else if (opcion == 2)
                {
                    puntos += 75;
                }
                else
                {
                    Console.WriteLine("Campaña finalizada.");
                }

            } 
            while (recursos > 0 && opcion != 3 && puntos < 4000);

            Console.WriteLine($"Puntos: {puntos}");

            if (puntos >= 3000)
                Console.WriteLine("COBERTURA AMPLIA");
            else if (puntos >= 1500)
                Console.WriteLine("COBERTURA MEDIA");
            else
                Console.WriteLine("COBERTURA LIMITADA");



        }
    }
}