using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej01_EST36
    {
        public static void Ejecutar(string[] args)
        {
         const int TOTAL_CRUCES = 9;
            int i = 1;
            do
            {
                Console.WriteLine($"Cruce semaforizado registrado: {i}");
                i++;
            }
            while (i <= TOTAL_CRUCES);
            Console.WriteLine($"Total procesado: {TOTAL_CRUCES} cruces.");
        }
    }
}