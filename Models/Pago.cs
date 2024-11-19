using System.ComponentModel.DataAnnotations;

namespace PropiedadesWEB.Models
{
	public class Pago
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "La fecha de pago es obligatoria.")]
		[DataType(DataType.Date, ErrorMessage = "La fecha de pago no tiene un formato válido.")]
		public string FechaPago { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "El monto debe ser mayor que 0.")]
		public int Monto { get; set; }

		[Required(ErrorMessage = "El estado del pago es obligatorio.")]
		public string Estado { get; set; }
		public int IdContrato { get; set; }
		public Contrato Contrato { get; set; }

	}
}