using System.ComponentModel.DataAnnotations;

namespace PropiedadesWEB.Models
{
	public class Contrato
	{
        public int Id { get; set; }

		[Required(ErrorMessage = "La fecha de inicio es obligatoria.")]
		[DataType(DataType.Date, ErrorMessage = "La fecha de inicio no tiene un formato válido.")]
		public string FechaInicio { get; set; }

		[Required(ErrorMessage = "La fecha de fin es obligatoria.")]
		[DataType(DataType.Date, ErrorMessage = "La fecha de fin no tiene un formato válido.")]
		public string FechaFin { get; set; }

		[Range(0, int.MaxValue, ErrorMessage = "El depósito debe ser positivo.")]
		public int Deposito { get; set; }

		[Required(ErrorMessage = "Los términos del contrato son obligatorios.")]
		[StringLength(1000, ErrorMessage = "Los términos no pueden tener más de 1000 caracteres.")]
		public string Terminos { get; set; }
		public int IdInquilino { get; set; }
		public int IdPropiedad { get; set; }
		public Propiedad Propiedad { get; set; }
		public Inquilino Inquilino { get; set; }
		public ICollection<Pago> Pagos { get; set; }
	}
}