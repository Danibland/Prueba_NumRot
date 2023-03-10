using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Convertir_m_M
    {
        public static void Conv_min()
        {
            Console.Write("Ingrese una pablabra en minúsculas: ");
            string palabra = Console.ReadLine();

             string palabra_M = palabra.ToUpper();

            Console.Write("La palabra se convierte a mayusculas :  "+palabra_M);
        }
    }
}
