using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_del_5_8.Cap_5
{
    public class Ejercicio_4_5
    {


        public void Menu()
        {
            Console.Clear();
            Console.Write("4.Ejercicio 4\n5.Ejercicio 5\nDigite la Opcion Deceada: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 4 || n == 5)
            {
                switch (n)
                {
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Factorial De un Numero Ejercicio 4 del Cap 5");
                        leerFactorial();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Cadena de Numeros Ejercicio 4 del Cap 5");
                        leernumero();
                        break;

                }
               
            }
            else
            {
                Console.WriteLine("No existe Este Ejercicio.");
            }
        }


        public void leerFactorial()
        {
            int n;
            Console.WriteLine("Digite un Numero: ");
            n = int.Parse(Console.ReadLine());

            Factorial(n);
        }

        //Ejercicio 4
        public int Factorial(int n)
        {


            int r = 1;



            if (n < 2)
            {
                Console.WriteLine("Factorial : 1");
            }
            else
            {
                for (int i = 1; i <= n; ++i)
                {
                    r = r * i;
                }


                Console.WriteLine("Factorial: " + r);
            }

            Console.ReadKey();
            return 0;
        }

        public void leernumero()
        {


            int numero;
            Console.WriteLine("\nCadena de Numero Enteros del 1 al 100 s\n");

            Console.Write("Digite Numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 100 || numero < 0)
            {
                Console.WriteLine("La Cadena de " + numero + " No Existe...");
                Console.WriteLine("Intentelo de Nuevo");
                leernumero();
            }
            else
            {
                Cadena(numero);
            }


            Console.ReadKey();
        }

        //Ejercicio 5
        public void Cadena(int numero)
        {
            String[] numeroletra = new string[] {"Cero", "Uno", "Dos"," Tres"," Cuatro"," Cinco", "Seis", " Siete", " Ocho", "Nueve", "Diez", "Once", " Doce", "Trece", "Catorce", "Quince", "Dieciséis", "Diecisiete", "Dieciocho", "Diecinueve","Veinte",
                                                 "Veintiuno","Veintidós",  "Veintitrés",  "Veinticuatro",  "Veinticinco",  "Veintiséis", "Veintisiete",  "Veintiocho", "Veintinueve","Treinta", "Treinta Y Uno",  "Treinta Y Dos",  "Treinta Y Tres", "Treinta Y Cuatro",  "Treinta Y Cinco",  "Treinta Y Seis",  "Treinta Y Siete",  "Treinta Y Ocho",  "Treinta Y Nueve",  "Cuarenta",
                                                  "Cuarenta Y Uno","Cuarenta Y Dos","Cuarenta Y Tres", "Cuarenta Y Cuatro","Cuarenta Y Cinco",  "Cuarenta Y Seis", "Cuarenta Y Siete", "Cuarenta Y Ocho",  "Cuarenta Y Nueve",  "Cincuenta",  "Cincuenta Y Uno",  "Cincuenta Y Dos",  "Cincuenta Y Tres", "Cincuenta Y Cuatro",  "Cincuenta Y Cinco",  "Cincuenta Y Seis",  "Cincuenta Y Siete",  "Cincuenta Y Ocho",  "Cincuenta Y Nueve",  "Sesenta", "Sesenta Y Uno",
                                                  "Sesenta Y Dos",  "Sesenta Y Tres",  "Sesenta Y Cuatro",  "Sesenta Y Cinco",  "Sesenta Y Seis",  "Sesenta Y Siete",  "Sesenta Y Ocho"," Sesenta Y Nueve",  "Setenta", "Setenta Y Uno","Setenta Y Dos", "Setenta Y Tres","Setenta Y Cuatro","Setenta Y Cinco","Setenta Y Seis" , "Setenta Y Siete"," Setenta Y Ocho"," Setenta Y Nueve"," Ochenta",
                                                  "Ochenta Y Uno", "Ochenta Y Dos"," Ochenta Y Tres"," Ochenta Y Cuatro"," Ochenta Y Cinco"," Ochenta Y Seis"," Ochenta Y Siete", "Ochenta Y Ocho", "Ochenta Y Nueve", "Noventa"," Noventa Y Uno"," Noventa Y Dos"," Noventa Y Tres"," Noventa Y Cuatro",  "Noventa Y Cinco"," Noventa Y Seis"," Noventa Y Siete"," Noventa Y Ocho"," Noventa Y Nueve", "Cien"};

            Console.WriteLine("Cadena: " + numeroletra[numero]);
            Console.ReadKey();
        }
    }
}
