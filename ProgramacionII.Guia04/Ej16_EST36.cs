using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej16_EST36
    {
        public static void Ejecutar(string[] args)
        {
            double totalInc = 0;
            int obs = 0;
            int i = 1;
            do
            {
                Console.Write($"Siniestros tramo {i}: ");
                double sin = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Valor base tramo {i}: ");
                double vb = Convert.ToDouble(Console.ReadLine());
                if (sin >= 15)
                {
                    totalInc += vb * 0.20;
                }
                else if (sin >= 6)
                {
                    totalInc += vb * 0.10;
                }
                else
                {
                    obs++;
                }
                i++;
            }
            while (i <= 9);
            Console.WriteLine($"Incentivo total: {totalInc}, Observaciones: {obs}");
        }
    }
}