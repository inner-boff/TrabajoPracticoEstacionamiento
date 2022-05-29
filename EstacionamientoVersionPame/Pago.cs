using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EstacionamientoVersionPame
{
    internal class Pago
    {
        double totalAPagar;
        public double calcularTotal(double tarifa, double horasTotales)
        {
            this.totalAPagar = tarifa * horasTotales;
            return totalAPagar;
        }

        // numTicket deberia ser un int --> corregir eso
        public void confirmarPago(string dni, string medioPago, string hSalida, string IDticket)
        {
            // variable con la ruta del archivo a modificar:
            string ticketPath = @$"E:\Mapache\PAMELA\IFTS 11\2doCuatrimestre\DSOO\tickets\ticket-{IDticket}.txt";

            using (StreamWriter sw = File.AppendText(ticketPath))
            {
                sw.WriteLine("..........");
                sw.WriteLine($"DNI Cliente : {dni}");
                sw.WriteLine($"Medio de Pago : {medioPago}");
                sw.WriteLine($"Hora de Salida : {hSalida}");
                //sw.WriteLine($"Total : {totalAPagar.ToString()}");
                sw.WriteLine("..........");
            }

        }
    }
}
