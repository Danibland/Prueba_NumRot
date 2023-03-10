using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Convertir_fecha
    {
        public static void fecha()
        {
            try
            {
                Console.WriteLine("Ingrese la fecha a convertir ,ejemplo: 'enero 25,2023': ");
                string fecha = Console.ReadLine();

                DateTime f_conv = DateTime.Parse(fecha);
                Console.WriteLine("La fecha convertida: " + f_conv);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
