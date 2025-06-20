using Practico.Entidades;

namespace Practico.Datos
{
    public class RepositorioVehiculosOperadores
    {
        private List<Vehiculo> vehiculos = new();
        public static RepositorioVehiculosLinq? instancia = null;

        public RepositorioVehiculosOperadores()
        {
        }

        public static RepositorioVehiculosLinq GetInstancia()
        {
            if (instancia is null)
            {
                instancia = new RepositorioVehiculosLinq();
            }
            return instancia;
        }
        public static bool operator ==(Vehiculo vehiculo, RepositorioVehiculosOperadores repo)
        {
            return repo.vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Vehiculo vehiculo, RepositorioVehiculosOperadores repo)
        {
            return !(vehiculo == repo);
        }
        public static bool operator +(Vehiculo vehiculo, RepositorioVehiculosOperadores repo)
        {
            if (vehiculo != repo)
            {
                repo.vehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator -(Vehiculo vehiculo, RepositorioVehiculosOperadores repo)
        {
            if (vehiculo == repo)
            {
                repo.vehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }
        public List<Vehiculo> GetLista()
        {
            return vehiculos;
        }

        public Vehiculo this[int index]
        {
            get
            {
                if (index < 0 || index >= vehiculos.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Índice fuera de rango.");

                }
                return vehiculos[index];
            }
        }
    }
}
