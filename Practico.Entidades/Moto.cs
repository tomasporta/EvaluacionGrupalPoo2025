using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Entidades
{
    public class Moto:Vehiculo
    {
        public int Cilindrada { get; set; }
        public Moto(Marca marca, Color color, string modelo, int anio, string patente, int cilindrada)
            : base(marca, color, modelo, anio, patente)
        {
            Cilindrada = cilindrada;
        }
        public override double CalcularCostoUso()
        {
            int antiguedad = DateTime.Now.Year - Anio;
            return 5 * antiguedad + Cilindrada * 0.1;
        }
        public override string Informar()
        {
            return base.Informar() + $"\nCilindrada: {Cilindrada} cc";
        }
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Validacion de Cilindrada
            if (Cilindrada <= 0)
            {
                yield return new ValidationResult("La cilindrada debe ser mayor a 0.", new[] { nameof(Cilindrada) });
            }
            // Llamar a la validacion base para otras propiedades
            foreach (var result in base.Validate(validationContext))
            {
                yield return result;
            }
        }
    }
}
