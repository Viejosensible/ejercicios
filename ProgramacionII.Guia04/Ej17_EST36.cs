using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace ejercicios_video.ejercicios
{
    public class Ej17_EST36
    {
        public static void Ejecutar(string[] args)
        {
            int n, cont = 0, suma = 0; while (true)
            { 
                Console.Write("Atenciones: ");
                n = int.Parse(Console.ReadLine());
                if (n == -1) break; cont++; suma += n;
            }
            if (cont > 0)
            { 
                double prom = (double)suma / cont;
                Console.WriteLine("Hospitales: " + cont);
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Promedio: " + prom);
                if (prom >= 900)
                    Console.WriteLine("Alta demanda");
                else if (prom >= 400)
                    Console.WriteLine("Demanda media");
                else 
                    Console.WriteLine("Baja demanda"); 
            } 
            else 
                Console.WriteLine("No hubo datos.");
        }
    }

        
}
