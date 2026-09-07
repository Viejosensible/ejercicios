using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ejercicios_video.ejercicios
{
    public class Ej20_EST36
    {
        public static void Ejecutar(string[] args)
        {
            const int N = 5, MIN = 0, MAX = 100, E = 65;

            
            {
                int op, total = 0;
                bool datos = false;

                do
                {
                    Console.WriteLine("\n1.Cargar  2.Reporte  3.Cobertura  4.Salir");
                    op = int.Parse(Console.ReadLine());

                    if (op == 1)
                    {
                        total = 0;

                        for (int i = 0; i < N; i++)
                        {
                            int x;
                            do
                            {
                                Console.Write("Precision: ");
                                x = int.Parse(Console.ReadLine());
                            } while (x < MIN || x > MAX);

                            total += x;
                        }

                        datos = true;
                    }
                    else if (op == 2)
                    {
                        if (datos)
                        {
                            double p = (double)total / N;
                            Console.WriteLine("Promedio: " + p);

                            if (p >= 90) Console.WriteLine("PRECISION EXCELENTE");
                            else if (p >= 60) Console.WriteLine("PRECISION ACEPTABLE");
                            else Console.WriteLine("PRECISION DEFICIENTE");
                        }
                        else Console.WriteLine("No hay datos.");
                    }
                    else if (op == 3)
                    {
                        if (datos)
                        {
                            int r = total, j = 0;
                            while (r > 0)
                            {
                                r -= E;
                                j++;
                            }
                            Console.WriteLine("Jornadas: " + j);
                        }
                        else Console.WriteLine("No hay datos.");
                    }
                    else
                    {
                        Console.WriteLine("Total: " + total);
                    }

                } while (op != 4);
            }
        }
    }
}
