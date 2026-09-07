using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej06_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const int RES_INICIAL = 3000;
            int reserva = RES_INICIAL;
            int limiteBajo = (int)(RES_INICIAL * 0.20);
            int jornadas = 0;
            if (reserva > 0)
            {
                do
                {
                    jornadas++;
                    reserva -= 300;
                    if (reserva < 0)
                    {
                        reserva = 0;
                    }
                    Console.WriteLine($"Jornada {jornadas}: Quedan {reserva}");
                    if (reserva < limiteBajo && reserva > 0)
                    {
                        Console.WriteLine("¡ALERTA! Menor al 20%.");
                    }
                }
                while (reserva > 0);
            }
            Console.WriteLine($"Total jornadas: {jornadas}");
        }
    }
}