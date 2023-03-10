using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Calculo_hipotenusa
    {
        public static void calc_hip()
        {
            Console.WriteLine("Ingrese la medida del lado A:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la medida del lado B:");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("La medida de la hipotenusa es: " + c);
        }
    }
}
