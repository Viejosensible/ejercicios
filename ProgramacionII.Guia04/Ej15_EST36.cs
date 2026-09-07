using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej15_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const int CLAVE = 2019;
            int intentos = 4;
            bool acceso = false;
            do
            {
                Console.Write("Código de acceso: ");
                if (Convert.ToInt32(Console.ReadLine()) == CLAVE)
                {
                    acceso = true;
                    Console.WriteLine("¡Acceso concedido!");
                }
                else
                {
                    intentos--;
                    Console.WriteLine($"Incorrecto. Quedan {intentos}");
                }
            }
            while (!acceso && intentos > 0);
        }
    }
}