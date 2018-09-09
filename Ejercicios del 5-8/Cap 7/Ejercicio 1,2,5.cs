using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_del_5_8.Cap_7
{
    public class Ejercicio_1_2_5
    {


        public void Menu()
        {
            Console.Clear();
            Console.Write("1.Ejercicio 1\n2.Ejercicio 2\n5.Ejercicio 5\nDijite el Numero De La Opcion Deceada: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 5 || n==2)
            {
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 1 Del Capitulo 7: ");
                        Calificaciones();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 2 Del Capitulo 7: ");
                        Diccionario();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 5 Del Capitulo 7: ");
                        AgendaTel();
                        break;
                }
            }else
                Console.WriteLine("Este Ejercicio no existe aun");
        }

        //Ejercicio 1
        public void Calificaciones()
        {
            string calificacion;
            int calificaciones;
            int promedio = 0, max = 0, min = 0;
            ArrayList clase = new ArrayList();
            Console.WriteLine("Programa que Dice el promedio, la maxima y la minima calificacion de un grupo de estudiantes");
            Console.WriteLine("Cantidad de Estudiantes: ");
            int n = int.Parse(Console.ReadLine());
            for (int x = 0; x<n;  x++)
            {
                Console.WriteLine("Digite calificacion");
                calificacion = Console.ReadLine();
                calificaciones = Convert.ToInt32(calificacion);
                if (calificaciones == 0)
                    break;
                clase.Add(calificaciones);

            }

            foreach (int datos in clase)
            {

                promedio +=datos;
                if (min == 0)
                    min = datos;

                if (datos > max)
                    max = datos;

                if (min > datos)
                    min = datos;
            }


            Console.WriteLine("Promedio: "+promedio/n);
            Console.WriteLine("Maximo: " + max);
            Console.WriteLine("Menor: " + min);
            Console.ReadKey();
        }


        //Ejercicio 2
        public void Diccionario()
        {
            Console.WriteLine("Diccionario");
            Hashtable Diccionario = new Hashtable();
            string op, valor;
            int ops;
            bool existe;
            Diccionario.Add("abaceria", "Tienda de comestibles");
            Diccionario.Add("abominar", "Condenar,maldecir");
            Diccionario.Add("acecinar", "Salar cualquier tipo de carne ahumada");
            do
            {
                Console.WriteLine("Tenemos las palabras: abaceria, abominar y acecinar  ");

                Console.WriteLine("Digite la palabra que desea");
                valor = Console.ReadLine();


                foreach (DictionaryEntry datos in Diccionario)
                {


                    if (valor == (string)datos.Key)
                    {
                        Console.WriteLine("La definiciones de {0} es:  {1}", datos.Key, datos.Value);
                        break;

                    }

                }

                existe = Diccionario.Contains(valor);
                if (existe == false)
                    Console.WriteLine("La palabra no se encuentra en el diccionario");

                Console.WriteLine("Digite 0 para salir, 1 para continuar");
                op = Console.ReadLine();
                ops = Convert.ToInt32(op);



            } while (ops != 0);
        }





        //Ejercicio 5 

        public struct Agendas
        {

            public String Nombre;
            public String telefono;
        }

        private void AgendaTel()
        {
            string salir;
            ArrayList Agenda = new ArrayList();
            Agendas h = new Agendas();


            for (int x = 0; ; x++)
            {
                Console.WriteLine("Digite el nombre");
                h.Nombre = Console.ReadLine();

                Console.WriteLine("Digite el numero de telefono");
                h.telefono = Console.ReadLine();

                Agenda.Add(h);

                Console.WriteLine("Si desea salir digite'salir' si no digite 'no'");
                salir = Console.ReadLine();
                if (salir == "salir" || salir == "Salir")
                    break;
            }

            Console.WriteLine("Agenda");
            foreach (Agendas datos in Agenda)
            {
                Console.WriteLine("Contactos:\n {0} {1} {2} {3}", "Nombre:", datos.Nombre,"Numero:", datos.telefono);

            }

            Console.ReadKey();
        }

    }
}

