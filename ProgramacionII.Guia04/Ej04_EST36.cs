using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej04_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const string MENU = "\n--- Archivo y Biblioteca Nacionales de Bolivia ---\n" +
                            "1) Ver el registro de documentos coloniales\n" +
                            "2) Ver la meta del periodo\n" +
                            "3) Ver el rango valido de folios transcritos del expediente\n" +
                            "4) Salir\n" +
                            "Elija una opcion: ";

            int opcion;

            do
            {
                Console.Write(MENU);
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Mostrando el registro de documentos coloniales del cerco de La Paz.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Meta del periodo: Transcribir folio por folio los expedientes de 1781.");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Rango valido de folios transcritos: Folio 1 al Folio 500.");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del sistema de consulta...");
                }
                else
                {
                    Console.WriteLine("La opcion no existe. Por favor, elija un numero entre 1 y 4.");
                }

            } while (opcion != 4);
        }
    }
}
