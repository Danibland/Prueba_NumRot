using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Promedios
    {
        public static void Promedio()
        {

            try
            {
                double promedio;
                double suma = 0;
                Console.Write("Ingrese la cantidad de números a promediar: ");
                string cantNum = Console.ReadLine();
                bool isNum = int.TryParse(cantNum, out int number);
                if (!isNum)
                {
                    Console.Clear();
                    Promedio();
                }
                else
                {
                    int cantidad = int.Parse(cantNum);

                    int[] numeros = new int[cantidad];

                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write("Por favor ingrese un número: ");
                        int numero = int.Parse(Console.ReadLine());
                        numeros[i] = numero;
                        suma += numeros[i];
                    }
                    promedio = suma / numeros.Length;
                    Console.WriteLine("El promedio de los números ingresados es: " + promedio);
                }
            }
            catch (Exception )
            {

                Console.WriteLine("No es el formato permitido,vuelve a intentarlo");
                Promedio();
            }
            
        }
    }
}
