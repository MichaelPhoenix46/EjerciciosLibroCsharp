
using Ejercicios_del_5_8.Cap_5;
using Ejercicios_del_5_8.Cap_7;
using Ejercicios_del_5_8.Cap_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_del_5_8
{
   public class Program
    {


        public static void Main(string[] args)
        {
            Console.Write("1.Cap 5\n2.Cap 6\n3.Cap 7\n4.Cap 8\nDigite El Capitulo Deceado: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    //
                    Ejercicio_4_5 cap5 = new Ejercicio_4_5();
                    cap5.Menu();
                    break;
                case 2:

                    Console.WriteLine("Aun No Terminado...");
                    break;
                case 3:

                    Ejercicio_1_2_5 cap7 = new Ejercicio_1_2_5();
                    cap7.Menu();
                    break;

                case 4:

                    Ejercicios_3_5 cap8 = new Ejercicios_3_5();
                    cap8.Menu();
                    break;


            }

        }


    }
}
