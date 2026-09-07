using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej05_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const int UMBRAL = 150;
            int cumplen = 0;
            int noCumplen = 0;
            int i = 1;
            do
            {
                Console.Write($"Objeto {i}: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor >= UMBRAL)
                {
                    Console.WriteLine("CUMPLE");
                    cumplen++;
                }
                else
                {
                    Console.WriteLine("NO CUMPLE");
                    noCumplen++;
                }
                i++;
            }
            while (i <= 5);
            Console.WriteLine($"Cumplen: {cumplen}, No cumplen: {noCumplen}");
        }
    }
}
