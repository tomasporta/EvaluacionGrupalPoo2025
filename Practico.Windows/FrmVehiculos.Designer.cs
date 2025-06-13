namespace Practico.Windows
{
    partial class FrmVehiculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculos));
            dgvDatos = new DataGridView();
            toolStrip1 = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            tsbFiltrar = new ToolStripDropDownButton();
            filtrarTipoToolStripMenuItem = new ToolStripMenuItem();
            autoToolStripMenuItem = new ToolStripMenuItem();
            camionetaToolStripMenuItem = new ToolStripMenuItem();
            motoToolStripMenuItem = new ToolStripMenuItem();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Patente = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            TipoVehiculo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Marca, Modelo, Año, Patente, Color, TipoVehiculo });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(800, 450);
            dgvDatos.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEditar, tsbEliminar, tsbActualizar, tsbFiltrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
          
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(69, 22);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
        
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(57, 22);
            tsbEditar.Text = "Editar";
            tsbEditar.Click += tsbEditar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(70, 22);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
          
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(79, 22);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { filtrarTipoToolStripMenuItem, autoToolStripMenuItem, camionetaToolStripMenuItem, motoToolStripMenuItem });
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
           
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(66, 22);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.Click += tsbFiltrar_Click;
            // 
            // filtrarTipoToolStripMenuItem
            // 
            filtrarTipoToolStripMenuItem.Name = "filtrarTipoToolStripMenuItem";
            filtrarTipoToolStripMenuItem.Size = new Size(132, 22);
            filtrarTipoToolStripMenuItem.Text = "FiltrarTodo";
            filtrarTipoToolStripMenuItem.Click += filtrarTipoToolStripMenuItem_Click;
            // 
            // autoToolStripMenuItem
            // 
            autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            autoToolStripMenuItem.Size = new Size(132, 22);
            autoToolStripMenuItem.Text = "Auto";
            autoToolStripMenuItem.Click += autoToolStripMenuItem_Click;
            // 
            // camionetaToolStripMenuItem
            // 
            camionetaToolStripMenuItem.Name = "camionetaToolStripMenuItem";
            camionetaToolStripMenuItem.Size = new Size(132, 22);
            camionetaToolStripMenuItem.Text = "Camioneta";
            camionetaToolStripMenuItem.Click += camionetaToolStripMenuItem_Click;
            // 
            // motoToolStripMenuItem
            // 
            motoToolStripMenuItem.Name = "motoToolStripMenuItem";
            motoToolStripMenuItem.Size = new Size(132, 22);
            motoToolStripMenuItem.Text = "Moto";
            motoToolStripMenuItem.Click += motoToolStripMenuItem_Click;
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Marca.HeaderText = "ColMarca";
            Marca.Name = "Marca";
            // 
            // Modelo
            // 
            Modelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Modelo.HeaderText = "ColModelo";
            Modelo.Name = "Modelo";
            // 
            // Año
            // 
            Año.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Año.HeaderText = "ColAño";
            Año.Name = "Año";
            // 
            // Patente
            // 
            Patente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Patente.HeaderText = "ColPatente";
            Patente.Name = "Patente";
            // 
            // Color
            // 
            Color.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Color.HeaderText = "ColColor";
            Color.Name = "Color";
            // 
            // TipoVehiculo
            // 
            TipoVehiculo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoVehiculo.HeaderText = "ColTipoVehiculo";
            TipoVehiculo.Name = "TipoVehiculo";
            // 
            // FrmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(dgvDatos);
            Name = "FrmVehiculos";
            Text = "frmVehiculos";
            Load += FrmVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbActualizar;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem filtrarTipoToolStripMenuItem;
        private ToolStripMenuItem autoToolStripMenuItem;
        private ToolStripMenuItem camionetaToolStripMenuItem;
        private ToolStripMenuItem motoToolStripMenuItem;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Patente;
        private DataGridViewTextBoxColumn Color;
        private DataGridViewTextBoxColumn TipoVehiculo;
    }
}
