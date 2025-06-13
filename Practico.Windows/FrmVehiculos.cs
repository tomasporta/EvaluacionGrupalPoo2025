
namespace Practico.Windows
{
    public partial class FrmVehiculos : Form
    {
        private VehiculosRepositorio repositorio = new VehiculosRepositorio();
        public FrmVehiculos()
        {
            InitializeComponent();
            this.Load += FrmVehiculos_Load;
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            ActualizarLista();

        }

        private void ActualizarLista()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = repositorio.ObtenerTodos();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                string patente = dgvDatos.SelectedRows[0].Cells["Patente"].Value.ToString();
                Vehiculo vehiculo = repositorio.BuscarPorPatente(patente);

                frmVehiculosAE frmAE = new frmVehiculosAE(vehiculo);
                if (frmAE.ShowDialog() == DialogResult.OK)
                {
                    repositorio.ActualizarVehiculo(vehiculo);
                    ActualizarLista();
                }
            }

        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {

            frmVehiculosAE frmVehiculosAE = new frmVehiculosAE(null);
            if (frmVehiculosAE.ShowDialog() == DialogResult.OK) 
            {
                repositorio.AgregarVehiculo(frmVehiculosAE.Vehiculo); 
                ActualizarLista(); 

            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                string patente = dgvDatos.SelectedRows[0].Cells["Patente"].Value.ToString();
                Vehiculo vehiculo = repositorio.BuscarPorPatente(patente);

                frmVehiculosAE frmAE = new frmVehiculosAE(vehiculo);
                if (frmAE.ShowDialog() == DialogResult.OK)
                {
                    repositorio.ActualizarVehiculo(vehiculo);
                    ActualizarLista();
                }
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

       
    }
}
