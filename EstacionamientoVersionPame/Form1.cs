namespace EstacionamientoVersionPame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validador = new ValidadorDeIngreso();
            if (validador.validarIngreso(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("Login Valido");
                this.Hide();
                var formPpal = new FormularioPrincipal();
                formPpal.Show();
            }
            else
            {
                MessageBox.Show("revise los datos ingresados");
            }
        }
    }
}