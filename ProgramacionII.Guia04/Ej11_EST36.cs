using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej11_EST36
    {
        public static void Ejecutar(string[] args)
        {
            int opcion;
            int urgentes = 0;
            do
            {
                Console.WriteLine("\n1) Registrar\n2) Consultar\n3) Salir\nOpción:");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.Write("Zona (1-Norte, 2-Sur): ");
                    int zona = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Urgente (1-Sí, 2-No): ");
                    int urg = Convert.ToInt32(Console.ReadLine());
                    if (urg == 1)
                    {
                        Console.WriteLine("Registrado URGENTE.");
                        urgentes++;
                    }
                    else
                    {
                        Console.WriteLine("Registrado normal.");
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Meta: Suministro continuo.");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine($"Saliendo. Urgentes: {urgentes}");
                }
            }
            while (opcion != 3);
        }
    }
}