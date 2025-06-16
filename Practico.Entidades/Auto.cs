using System.ComponentModel.DataAnnotations;

namespace Practico.Entidades
{
    public class Auto:Vehiculo
    {
        public int CantPuertas { get; set; }
        public Auto(Marca marca, Color color, string modelo, int anio, string patente, int cantPuertas)
            : base(marca, color, modelo, anio, patente)
        {
            CantPuertas = cantPuertas;
        }
        public override double CalcularCostoUso()
        {
            int antiguedad = DateTime.Now.Year - Anio;
            return 10 * antiguedad;
        }
        public override string Informar()
        {
            return base.Informar() + $"\nCantidad de Puertas: {CantPuertas}";
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Validacion de CantPuertas
            if (CantPuertas < 2 || CantPuertas > 5)
            {
                yield return new ValidationResult("La cantidad de puertas debe estar entre 2 y 5.", new[] { nameof(CantPuertas) });
            }
            // Llamar a la validacion base para otras propiedades
            foreach (var result in base.Validate(validationContext))
            {
                yield return result;
            }
        }
    }
}
