using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Convertir_dec_bin
    {
        public static void dec_bin()
        {
            try
            {
                int[] residuos = new int[50];
                int i = 0;
                Console.Write("Ingrese el número a convertir: ");
                int num = int.Parse(Console.ReadLine());

                while (num > 0)
                {
                    residuos[i] = num % 2;
                    num = num / 2;
                    i++;
                }

                Console.Write("El numero ingresado en binario es: ");
                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write(residuos[j]);

                }

            }
            catch (Exception)
            {

                Console.WriteLine("No es el formato permitido, vuelva a intentarlo ");
                dec_bin();
            }


        }
    }
}
