using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej07_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const double INSPECCION_ALTA = 180;
            const double INSPECCION_MEDIA = 70;
            int alta = 0;
            int media = 0;
            int baja = 0;
            int i = 1;
            do
            {
                Console.Write($"Km tramo {i}: ");
                double km = Convert.ToDouble(Console.ReadLine());
                if (km >= INSPECCION_ALTA)
                {
                    Console.WriteLine("ALTA");
                    alta++;
                }
                else if (km >= INSPECCION_MEDIA)
                {
                    Console.WriteLine("MEDIA");
                    media++;
                }
                else
                {
                    Console.WriteLine("BAJA");
                    baja++;
                }
                i++;
            }
            while (i <= 9);
            Console.WriteLine($"Resumen: Alta={alta}, Media={media}, Baja={baja}");
        }
    }
}