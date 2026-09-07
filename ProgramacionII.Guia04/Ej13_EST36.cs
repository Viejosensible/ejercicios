using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej13_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const double META = 20000;
            double acumulado = 0;
            int periodos = 0;
            do
            {
                periodos++;
                Console.Write($"Avance periodo {periodos}: ");
                acumulado += Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Acumulado: {acumulado}");
            }
            while (acumulado < META);
            Console.WriteLine($"Meta alcanzada en {periodos} periodos.");
        }
    }
}
