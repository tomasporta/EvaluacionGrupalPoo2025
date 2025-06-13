namespace Practico.Windows
{
    partial class frmVehiculosAE
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
            label1 = new Label();
            label2 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtModelo = new TextBox();
            txtPatente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMarca = new TextBox();
            txtAño = new TextBox();
            txtColor = new TextBox();
            txtVehiculo = new TextBox();
            cmbTipo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 95);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Patente";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 264);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(135, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(99, 29);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 7;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(99, 95);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 58);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 10;
            label4.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 137);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 170);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 12;
            label6.Text = "Tipo De Vehiculo";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(99, 0);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 13;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(99, 58);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 14;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(99, 129);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 15;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(99, 162);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(100, 23);
            txtVehiculo.TabIndex = 16;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(302, 206);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 17;
            // 
            // frmVehiculosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 512);
            Controls.Add(cmbTipo);
            Controls.Add(txtVehiculo);
            Controls.Add(txtColor);
            Controls.Add(txtAño);
            Controls.Add(txtMarca);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPatente);
            Controls.Add(txtModelo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVehiculosAE";
            Text = "frmVehiculosAE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtModelo;
        private TextBox txtPatente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMarca;
        private TextBox txtAño;
        private TextBox txtColor;
        private TextBox txtVehiculo;
        private ComboBox cmbTipo;
    }
}