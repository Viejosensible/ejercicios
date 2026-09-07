using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios_video
{
    public class MenuPrincipal
    {
        public static void Main(string[] args)
        {
            int opcion;
            do
            {
                System.Console.Clear();
                System.Console.WriteLine("========================================");
                System.Console.WriteLine("       MENÚ DE EJERCICIOS - EST36       ");
                System.Console.WriteLine("========================================");
                for (int i = 1; i <= 20; i++)
                {
                    System.Console.WriteLine($"{i,2}) Ejecutar Ejercicio {i:D2}");
                }
                System.Console.WriteLine(" 0) Salir");
                System.Console.WriteLine("========================================");
                System.Console.Write("Seleccione una opción: ");

                opcion = System.Convert.ToInt32(System.Console.ReadLine());

                System.Console.Clear();
                switch (opcion)
                {
                    case 1: ejercicios.Ej01_EST36.Ejecutar(args); break;
                    case 2: ejercicios.Ej02_EST36.Ejecutar(args); break;
                    case 3: ejercicios.Ej03_EST36.Ejecutar(args); break;
                    case 4: ejercicios.Ej04_EST36.Ejecutar(args); break;
                    case 5: ejercicios.Ej05_EST36.Ejecutar(args); break;
                    case 6: ejercicios.Ej06_EST36.Ejecutar(args); break;
                    case 7: ejercicios.Ej07_EST36.Ejecutar(args); break;
                    case 8: ejercicios.Ej08_EST36.Ejecutar(args); break;
                    case 9: ejercicios.Ej09_EST36.Ejecutar(args); break;
                    case 10: ejercicios.Ej10_EST36.Ejecutar(args); break;
                    case 11: ejercicios.Ej11_EST36.Ejecutar(args); break;
                    case 12: ejercicios.Ej12_EST36.Ejecutar(args); break;
                    case 13: ejercicios.Ej13_EST36.Ejecutar(args); break;
                    case 14: ejercicios.Ej14_EST36.Ejecutar(args); break;
                    case 15: ejercicios.Ej15_EST36.Ejecutar(args); break;
                    case 16: ejercicios.Ej16_EST36.Ejecutar(args); break;
                    case 17: ejercicios.Ej17_EST36.Ejecutar(args); break;
                    case 18: ejercicios.Ej18_EST36.Ejecutar(args); break;
                    case 19: ejercicios.Ej19_EST36.Ejecutar(args); break;
                    case 20: ejercicios.Ej20_EST36.Ejecutar(args); break;
                    case 0:
                        System.Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        System.Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 0)
                {
                    System.Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    System.Console.ReadKey();
                }
            }
            while (opcion != 0);
        }
    }
}