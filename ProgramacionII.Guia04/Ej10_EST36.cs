using System;
using System.Collections.Generic;
using System.Text;


namespace ejercicios_video.ejercicios
{
    public class Ej10_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const int TOTAL_FOCOS = 9;
            const double UMBRAL = 500;
            double suma = 0;
            int i = 1;
            do
            {
                Console.Write($"Hectáreas foco {i}: ");
                suma += Convert.ToDouble(Console.ReadLine());
                i++;
            }
            while (i <= TOTAL_FOCOS);
            double prom = suma / TOTAL_FOCOS;
            Console.WriteLine($"Promedio: {prom:F2} - " + (prom > UMBRAL ? "Requiere intervención." : "Aceptable."));
        }
    }
}