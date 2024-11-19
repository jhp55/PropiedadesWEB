using System.ComponentModel.DataAnnotations;

namespace PropiedadesWEB.Models
{
	public class Propiedad
	{
        public int Id { get; set; }

		[Required(ErrorMessage = "La dirección es obligatoria.")]
		[StringLength(200, ErrorMessage = "La dirección no puede tener más de 200 caracteres.")]
		public string Direccion { get; set; }

		[Required(ErrorMessage = "El tipo de propiedad es obligatorio.")]
		public string TipoPropiedad { get; set; }


		public int NumeroHabitaciones { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "El precio de alquiler debe ser positivo.")]
		public int PrecioAlquiler { get; set; }
        public int Disponible { get; set; }
		public ICollection<Inquilino> Inquilinos { get; set; }
		public ICollection<Contrato> Contratos { get; set; }
    }
}
