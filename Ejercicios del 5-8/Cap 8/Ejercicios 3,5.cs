using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_del_5_8.Cap_8
{

    public class Ejercicios_3_5
    {
        //Ejercicio 3


        public void Menu()
        {
            Console.Clear();
            Console.Write("3.Ejercicio 3\n5.Ejercicio 5\nDijite el Numero De La Opcion Deceada: ");
            int n = int.Parse(Console.ReadLine());
            if(n==3 || n== 5)
            {
                switch (n)
                {
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 3 Del Capitulo 8: ");
                        Fecha();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Ejercicio 5 Del Capitulo 8: ");
                        Cadenas();
                        break;
                }
               
            }else
                Console.WriteLine("Este Ejercicio no existe aun");


        }


        public void Fecha()
        {
            String formato, formatos;
            formatos = DateTime.Now.ToString("h:mm: ss tt ");
            formato = DateTime.Now.ToString("yyyy/dd/MM");
            Console.WriteLine("La hora es: {0} ", formatos);
            Console.WriteLine("La fecha es:{0} ", formato);
            Console.ReadKey();

        }

        

        public void Cadenas()
        {
            string cadena, caden;
            ArrayList cadenas = new ArrayList();


            Console.WriteLine("Digite cadena 1");
            cadena = Console.ReadLine();
            cadenas.Add(cadena);

            Console.WriteLine("Digite cadena 2");
            caden = Console.ReadLine();
            cadenas.Add(caden);


            cadenas.Sort();

            foreach (string datos in cadenas)
            {

                Console.WriteLine("\n{0}", datos);


            }

            Console.ReadKey();
        }
    }
}
