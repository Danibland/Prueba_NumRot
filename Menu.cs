using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Menu
    {
        public static void menu()
        {

            try
            {
                Console.WriteLine("***** MENU *****");
                Console.WriteLine(" 1 )- Haga una función que determine el promedio de N números agrupados en un arreglo numérico. \n ");
                Console.WriteLine(" 2 )- Realice un algoritmo que a partir de un valor total a pagar sea capaz de informar el valor " +
                                  "del IVA(19 %) y que permita etiquetar dicho precio bajo diferentes categorías  \n ");
                Console.WriteLine(" 3 )- Realizar un algoritmo que permita convertir un numero decimal a número binario " +
                                  " ,En modo consola ingresar el numero a convertir y mostrar el equivalente en binario \n ");
                Console.WriteLine(" 4 )- Haga un programa que cuando se ingrese los lados A y B, se calcule y se muestre el valor de C \n");
                Console.WriteLine(" 5 )- Realice un programa que convierta textos con letras en minúsculas a un nuevo texto con todo en MAYUSCULAS \n");
                Console.Write(" 6 )- Realice un programa para convertir fechas en texto a año.mes.dia hh:mm:ss \n ");
                Console.Write("\n Seleccione una opción:  \n ");

                string opcion = Console.ReadLine();
                bool isNum = int.TryParse(opcion, out int number);
                if (!isNum)
                {
                    Console.Clear();
                    menu();
                }
                else
                {

                    switch (int.Parse(opcion))
                    {
                        case 1:

                            Promedios.Promedio();

                            break;
                        case 2:

                            Validar_iva.Validariva();

                            break;
                        case 3:

                            Convertir_dec_bin.dec_bin();

                            break;

                        case 4:

                            Calculo_hipotenusa.calc_hip();

                            break;

                        case 5:

                            Convertir_m_M.Conv_min();

                            break;

                        case 6:

                            Convertir_fecha.fecha();

                            break;

                        default:

                            Console.WriteLine("La selección es incorrecta");

                            break;
                    }
                }
            }
            catch (Exception )
            {
                Console.WriteLine("No es el formato permitido");
                

            }
        }
    }
}
