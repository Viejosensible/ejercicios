using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej02_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const double META = 12000;
            double suma = 0;
            int i = 1;

            while (i <= 5)
            {
                Console.Write($"Litros ahorrados en parcela {i}: ");
                suma += Convert.ToDouble(Console.ReadLine());
                i++;
            }

            Console.WriteLine($"\nTotal acumulado: {suma} litros.");

            if (suma >= META)
                Console.WriteLine("Se alcanzó la meta de 12000 litros");
            else
                Console.WriteLine("No se alcanzó la meta de 12000 litros");
        }

    }
 }