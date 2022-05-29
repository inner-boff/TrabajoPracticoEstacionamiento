using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EstacionamientoVersionPame
{
    internal class Ticket
    {
        //double total;
        //string horaEntrada;
        //string horaSalida;
        //string estado; // "por pagar" o "pagado"


        // OJO, el numTicket debería generarse automáticamente, pero por ahora lo planteo así para probar.
        public void generarTicket(string patente, string lugar, string hEntrada, string IDticket)
        {
            //this.estado = "por pagar";
            
            StreamWriter sw = new StreamWriter(@$"E:\Mapache\PAMELA\IFTS 11\2doCuatrimestre\DSOO\tickets\ticket-{IDticket}.txt", true);
            sw.WriteLine("..........");
            sw.WriteLine($"Numero de Ticket : {IDticket}");
            sw.WriteLine($"Patente : {patente}");
            sw.WriteLine($"Lugar : {lugar}");
            sw.WriteLine($"Hora de entrada : {hEntrada}");
            sw.WriteLine("..........");
            sw.Close();
        }

    }
}
