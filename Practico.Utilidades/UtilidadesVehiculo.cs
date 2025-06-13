using Practico.Entidades;

namespace Practico.Utilidades
{
    public class UtilidadesVehiculo
    {
        public static decimal CostoTotalUso(IEnumerable<Vehiculo> vehiculos)
        {
            return vehiculos.Sum(v => v.CalcularCostoUso());
        }

        public static double PromedioAntiguedad(IEnumerable<Vehiculo> vehiculos)
        {
            return vehiculos.Average(v => DateTime.Now.Year - v.Año);
        }

        public static Vehiculo VehiculoMasAntiguo(IEnumerable<Vehiculo> vehiculos)
        {
            return vehiculos.OrderBy(v => v.Año).FirstOrDefault();
        }
    }
}
