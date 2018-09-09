using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCsharp.Chapter6
{
    class ejercicios1_2_3_4_5
    {
        public void cap6_1()
        {
            int cantEstudiantes = 0, cantSalones = 0, i = 0, j = 0;
            float suma = 0.0f;
            float prom = 0.0f;
            string entrada;

            Console.Write("\nDigite la cantidad de salones: ");
            entrada = Console.ReadLine();
            cantSalones = Convert.ToInt32(entrada);

            float[][] calif = new float[cantSalones][];

            for (i = 0; i < cantSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}", i + 1);
                entrada = Console.ReadLine();
                cantEstudiantes = Convert.ToInt32(entrada);

                calif[i] = new float[cantEstudiantes];
            }

            for (i = 0; i < cantSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    entrada = Console.ReadLine();
                    calif[i][j] = Convert.ToSingle(entrada);
                }

            }

            for (i = 0; i < cantSalones; i++)
            {
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    suma += calif[i][j];

                }
            }
            prom = suma / (cantEstudiantes * cantSalones);
            Console.WriteLine("\nEl promedio es: {0}\n", prom);
        }

        public void cap6_2()
        {
            int cantEstudiantes = 0, cantSalones = 0, i = 0, j = 0;
            float minima = 100.0f;
            string entrada;

            Console.Write("\nDigite la cantidad de salones: ");
            entrada = Console.ReadLine();
            cantSalones = Convert.ToInt32(entrada);

            float[][] calif = new float[cantSalones][];

            for (i = 0; i < cantSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);
                entrada = Console.ReadLine();
                cantEstudiantes = Convert.ToInt32(entrada);

                calif[i] = new float[cantEstudiantes];
            }

            for (i = 0; i < cantSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    entrada = Console.ReadLine();
                    calif[i][j] = Convert.ToSingle(entrada);
                }

            }

            for (i = 0; i < cantSalones; i++)
            {
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    if (calif[i][j] < minima)
                    {
                        minima = calif[i][j];
                    }
                }
            }
            Console.WriteLine("\nLa nota mas baja es: {0}\n", minima);
        }

        public void cap6_3()
        {
            int cantEstudiantes = 0, cantSalones = 0, i = 0, j = 0;
            float maxima = 0.0f;
            string entrada;

            Console.Write("\nDigite la cantidad de salones: ");
            entrada = Console.ReadLine();
            cantSalones = Convert.ToInt32(entrada);

            float[][] calif = new float[cantSalones][];

            for (i = 0; i < cantSalones; i++)
            {
                Console.Write("\nDigite la cantidad de estudiantes para el salon {0}: ", i + 1);
                entrada = Console.ReadLine();
                cantEstudiantes = Convert.ToInt32(entrada);

                calif[i] = new float[cantEstudiantes];
            }

            for (i = 0; i < cantSalones; i++)
            {
                Console.WriteLine("\nCurso {0}\n", i + 1);
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    Console.Write("Digita la calificacion: ");
                    entrada = Console.ReadLine();
                    calif[i][j] = Convert.ToSingle(entrada);
                }

            }

            for (i = 0; i < cantSalones; i++)
            {
                for (j = 0; j < calif[i].GetLength(0); j++)
                {
                    if (calif[i][j] > maxima)
                    {
                        maxima = calif[i][j];
                    }
                }
            }
            Console.WriteLine("\nLa nota mas alta es: {0}\n", maxima);
        }
    }
}