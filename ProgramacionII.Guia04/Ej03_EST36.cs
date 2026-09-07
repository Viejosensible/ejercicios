using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej03_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const int MIN_VAL = 0;
            const int MAX_VAL = 900;
            int descargas;
            do
            {
                Console.Write("Ingrese descargas (0-900): ");
                descargas =Convert.ToInt32(Console.ReadLine());
                if (descargas < MIN_VAL || descargas > MAX_VAL)
                {
                    Console.WriteLine("Error de rango");
                }
            }
            while (descargas < MIN_VAL || descargas > MAX_VAL);
            Console.WriteLine($"Válido: {descargas}");
        }
    }
}
