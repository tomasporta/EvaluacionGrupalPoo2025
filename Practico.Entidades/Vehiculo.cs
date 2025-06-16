using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Practico.Entidades
{
    // Definicion de enumeraciones para Marca y Color
    public enum Marca
    {
        Ford, Chevrolet, Toyota, Honda, Yamaha, Fiat
    }

    public enum Color
    {
        Rojo, Azul, Negro, Blanco, Gris, Verde
    }
    public abstract class Vehiculo : IValidatableObject
    {
        // Atributos
        public Marca Marca { get; set; }
        public Color Color { get; set; }
        public int Anio { get; set; }
        public string Patente { get; set; }
        public string Modelo { get; set; }  
        // Constructor
        public Vehiculo(Marca marca, Color color, string modelo, int anio, string patente)
        {
            Marca = marca;
            Color = color;
            Modelo = modelo;
            Anio = anio;
            Patente = patente;
        }
        // Metodos Virtuales
        // 
        public virtual double CalcularCostoUso()
        {
            return 0;
        }
        //
        public virtual string Informar()
        {
            return $"Marca: {Marca}\nModelo: {Modelo}\nAño: {Anio}\nPatente: {Patente}\nColor: {Color}\nCosto de Uso: ${CalcularCostoUso():0.00}";
        }
        // Implementación de IValidatableObject para validaciones personalizadas
        public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int añoActual = DateTime.Now.Year;
            //Año valido
            if (Anio < 1990 || Anio > añoActual)
            {
                yield return new ValidationResult($"El año debe estar entre 1990 y {añoActual}.", new[] { nameof(Anio) });
            }
            //Modelo no vacio
            if (string.IsNullOrWhiteSpace(Modelo))
            {
                yield return new ValidationResult("El modelo no puede estar vacío.", new[] { nameof(Modelo) });
            }
            //Patente formato correcto
            string formatoViejo = @"^[A-Z]{3}\d{3}$";       //ABC123
            string formatoNuevo = @"^[A-Z]{2}\d{3}[A-Z]{2}$"; //AB123CD
            bool esFormatoViejo = Regex.IsMatch(Patente, formatoViejo);
            bool esFormatoNuevo = Regex.IsMatch(Patente, formatoNuevo);
            if (!esFormatoViejo && !esFormatoNuevo)
            {
                yield return new ValidationResult("La patente no tiene un formato valido.", new[] { nameof(Patente) });
            }
            //Patentes nuevas desde 2016 deben tener formato nuevo
            if (Anio >= 2016 && !esFormatoNuevo)
            {
                yield return new ValidationResult("Las patentes a partir de 2016 deben usar el formato nuevo (AB123CD).", new[] { nameof(Patente) });
            }
            //Costo de uso no negativo
            if (CalcularCostoUso() < 0)
            {
                yield return new ValidationResult("El costo de uso no puede ser negativo.", new[] { nameof(CalcularCostoUso) });
            }
        }
    }
}
