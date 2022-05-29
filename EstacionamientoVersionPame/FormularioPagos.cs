using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacionamientoVersionPame
{
    public partial class FormularioPagos : Form
    {
        public FormularioPagos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // el total de horas está hardcodeado por ahora,
            // habría que hacer el cálculo desde los datos ingresados
            //double totalHoras = 5;

            var nuevoPago = new Pago();

            // para que en la etiqueta se muestre el total a pagar:
            //txtTotal.Text = nuevoPago.calcularTotal(Convert.ToDouble(txtTarifa), totalHoras).ToString();

            // Si está ok se confirma el pago y se actualiza el ticket.
            nuevoPago.confirmarPago(txtDNI.Text, txtMedioPago.Text, txtHoraSalida.Text, txtNumTicketAPagar.Text);

            MessageBox.Show("Se confirmó el pago - Puede ver el ticket en el directorio correspondiente");

            

        }
    }
}
