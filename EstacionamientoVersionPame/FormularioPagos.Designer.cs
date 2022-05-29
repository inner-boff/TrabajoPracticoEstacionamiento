namespace EstacionamientoVersionPame
{
    partial class FormularioPagos
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedioPago = new System.Windows.Forms.TextBox();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumTicketAPagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirmar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "DNI Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(158, 40);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Medio de Pago";
            // 
            // txtMedioPago
            // 
            this.txtMedioPago.Location = new System.Drawing.Point(158, 85);
            this.txtMedioPago.Name = "txtMedioPago";
            this.txtMedioPago.Size = new System.Drawing.Size(100, 23);
            this.txtMedioPago.TabIndex = 7;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(158, 129);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(100, 23);
            this.txtHoraSalida.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hora de salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tarifa";
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(158, 173);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(100, 23);
            this.txtTarifa.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total a pagar:";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(206, 261);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(22, 15);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero de ticket";
            // 
            // txtNumTicketAPagar
            // 
            this.txtNumTicketAPagar.Location = new System.Drawing.Point(158, 215);
            this.txtNumTicketAPagar.Name = "txtNumTicketAPagar";
            this.txtNumTicketAPagar.Size = new System.Drawing.Size(100, 23);
            this.txtNumTicketAPagar.TabIndex = 15;
            // 
            // FormularioPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 376);
            this.Controls.Add(this.txtNumTicketAPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtMedioPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "FormularioPagos";
            this.Text = "FormularioPagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox txtDNI;
        private Label label4;
        private TextBox txtMedioPago;
        private TextBox txtHoraSalida;
        private Label label5;
        private Label label1;
        private TextBox txtTarifa;
        private Label label2;
        private Label txtTotal;
        private Label label7;
        private TextBox txtNumTicketAPagar;
    }
}