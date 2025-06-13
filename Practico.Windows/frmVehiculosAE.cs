using Practico.Entidades;
using Color = Practico.Entidades.Color;

namespace Practico.Windows
{
    public partial class frmVehiculosAE : Form
    {
        public Vehiculo Vehiculo { get; private set; }

        public frmVehiculosAE(Vehiculo vehiculo)
        {
            InitializeComponent();
            CargarTiposVehiculo();

            if (vehiculo != null)
            {
                txtMarca.Text = vehiculo.Marca.ToString();
                txtModelo.Text = vehiculo.Modelo;
                txtAño.Text = vehiculo.Año.ToString();
                txtPatente.Text = vehiculo.Patente;
                txtColor.Text = vehiculo.Color.ToString();
                cmbTipo.SelectedItem = vehiculo.GetType().Name;
            }


        }
        private void CargarTiposVehiculo()
        {
            cmbTipo.Items.AddRange(new string[] { "Auto", "Camioneta", "Moto" });
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int año = int.Parse(txtAño.Text);
                string patente = txtPatente.Text;
                string color = txtColor.Text;
                string tipo = cmbTipo.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo) || string.IsNullOrEmpty(patente) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Vehiculo nuevoVehiculo = tipo switch
                {
                    "Auto" => new Auto { Marca = Enum.Parse<Marca>(marca), Modelo = modelo, Año = año, Patente = patente, Color = Enum.Parse<Color>(color) },
                    "Camioneta" => new Camioneta { Marca = Enum.Parse<Marca>(marca), Modelo = modelo, Año = año, Patente = patente, Color = Enum.Parse<Color>(color) },
                    "Moto" => new Moto { Marca = Enum.Parse<Marca>(marca), Modelo = modelo, Año = año, Patente = patente, Color = Enum.Parse<Color>(color) },
                    _ => null
                };

                if (nuevoVehiculo != null)
                {
                    DialogResult = DialogResult.OK; // ✅ Indica éxito para `FrmPrincipal`
                    Vehiculo = nuevoVehiculo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
