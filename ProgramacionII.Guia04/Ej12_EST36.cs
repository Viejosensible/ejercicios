using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej12_EST36
    {
        public static void Ejecutar(string[] args)
        {
            int conf = 0;
            int pend = 0;
            int i = 1;
            do
            {
                Console.Write($"Hectáreas parcela {i}: ");
                double ha = Convert.ToDouble(Console.ReadLine());
                if (ha >= 400)
                {
                    Console.Write("¿Verificado? (1-Sí, 2-No): ");
                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                    {
                        Console.WriteLine("CONFIRMADO");
                        conf++;
                    }
                    else
                    {
                        Console.WriteLine("PENDIENTE");
                        pend++;
                    }
                }
                else if (ha >= 150)
                {
                    Console.WriteLine("MODERADO");
                }
                else
                {
                    Console.WriteLine("LEVE");
                }
                i++;
            }
            while (i <= 7);
            Console.WriteLine($"Confirmados: {conf}, Pendientes: {pend}");
        }
    }
}
