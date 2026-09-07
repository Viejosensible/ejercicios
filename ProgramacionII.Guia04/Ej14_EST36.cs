using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej14_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const double UMBRAL = 500;
            double totalGen = 0;
            int zona = 1;
            do
            {
                double subtotal = 0;
                int dia = 1;
                do
                {
                    Console.Write($"Dosis día {dia}: ");
                    subtotal += Convert.ToDouble(Console.ReadLine());
                    dia++;
                }while (dia <= 4);
                Console.WriteLine($"Subtotal Zona {zona}: {subtotal} - " + (subtotal > UMBRAL ? "ÓPTIMA" : "BAJA"));
                totalGen += subtotal;
                zona++;
            }
            while (zona <= 2);
            Console.WriteLine($"Total general: {totalGen}");
        }
    }
}