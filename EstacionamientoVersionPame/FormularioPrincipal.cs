using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Hay que agregar esta libreria

namespace EstacionamientoVersionPame
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nuevoPago = new FormularioPagos();
            nuevoPago.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            // cuando se hace click en el botón, se genera un nuevo objeto ticket
            // armado igual que el login para separar la interfaz de la lógica

            var nuevoTicket = new Ticket();
            nuevoTicket.generarTicket(txtPatente.Text, txtLugar.Text, txtHoraEntrada.Text, txtNumTicket.Text);
            MessageBox.Show("Se generó un nuevo ticket - Puede verlo en el directorio correspondiente");

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
