using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_NumRot
{
    internal class Validar_iva
    {
        public static void Validariva()
        {
            try
            {
                Console.Write("Ingrese el monto a pagar: ");
                double monto = double.Parse(Console.ReadLine());

                double tasaiva = 19;
                double iva = monto * tasaiva / 100;

                string Monto_n = monto.ToString("#,##0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
                string iva_n = iva.ToString("#,##0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                if (monto <= 100000.00)
                {

                    Console.WriteLine("BARATO");
                }
                else if (monto > 100000.01 && monto < 150000.00)
                {
                    Console.WriteLine("COMÚN");
                }
                else
                {
                    Console.WriteLine("CARO");
                }
                Console.WriteLine("El monto a pagar es :" + Monto_n);
                Console.WriteLine("El IVA del 19% es : " + iva_n);

            }
            catch (Exception)
            {

               Console.WriteLine("No es el formato permitido,vuelva a intentarlo ");
               Validariva();
            }
            
        }
    }
}
