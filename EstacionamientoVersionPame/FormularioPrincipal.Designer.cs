namespace EstacionamientoVersionPame
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumTicket = new System.Windows.Forms.TextBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente del Vehiculo";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(235, 44);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 23);
            this.txtPatente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lugar estacionamiento";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(235, 95);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 23);
            this.txtLugar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generar Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 7;
            this.button2.Text = "Ir a formulario de pagos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de Ticket";
            // 
            // txtNumTicket
            // 
            this.txtNumTicket.Location = new System.Drawing.Point(235, 188);
            this.txtNumTicket.Name = "txtNumTicket";
            this.txtNumTicket.Size = new System.Drawing.Size(100, 23);
            this.txtNumTicket.TabIndex = 9;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(235, 140);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(100, 23);
            this.txtHoraEntrada.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hora de Entrada";
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtNumTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label1);
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtPatente;
        private Label label2;
        private TextBox txtLugar;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox txtNumTicket;
        private TextBox txtHoraEntrada;
        private Label label4;
    }
}