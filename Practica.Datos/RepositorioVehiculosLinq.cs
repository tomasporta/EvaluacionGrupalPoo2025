using Practico.Entidades;

namespace Practico.Datos
{
    public class RepositorioVehiculosLinq
    {
        private readonly List<Vehiculo> vehiculos;

        public RepositorioVehiculosLinq()
        {
            vehiculos = new List<Vehiculo>();
        }
        public Vehiculo BuscarPorPatente(string patente)
        {
            return vehiculos.FirstOrDefault(v => v.Patente == patente);
        }

        public List<Vehiculo> ListarPorTipo(string tipo)
        {
            return vehiculos.Where(v => v.GetType().Name == tipo).ToList();
        }
        public List<Vehiculo> ListarPorCostoUsoMayorA(decimal monto)
        {
            return vehiculos.Where(v => (decimal)v.CalcularCostoUso() > monto).ToList();
        }

        public List<Vehiculo> OrdenarPorAño()
        {
            return vehiculos.OrderBy(v => v.Anio).ToList();
        }
    }
}
