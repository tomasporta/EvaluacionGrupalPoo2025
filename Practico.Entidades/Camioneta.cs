using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Entidades
{
    public class Camioneta:Vehiculo
    {
        public double CapacidadCarga { get; set; }
        public Camioneta(Marca marca, Color color, string modelo, int anio, string patente, double capacidadCarga)
            : base(marca, color, modelo, anio, patente)
        {
            CapacidadCarga = capacidadCarga;
        }  
        public override double CalcularCostoUso()
        {
            int antiguedad = DateTime.Now.Year - Anio;
            return 15 * antiguedad + CapacidadCarga * 0.5;
        }
        public override string Informar()
        {
            return base.Informar() + $"\nCapacidad de Carga: {CapacidadCarga} kg";
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Validacion de CapacidadCarga
            if (CapacidadCarga <= 0)
            {
                yield return new ValidationResult("La capacidad de carga debe ser mayor a 0.", new[] { nameof(CapacidadCarga) });
            }
            // Llamar a la validacion base para otras propiedades
            foreach (var result in base.Validate(validationContext))
            {
                yield return result;
            }
        }
    }
}
