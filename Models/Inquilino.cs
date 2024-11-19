using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace PropiedadesWEB.Models
{
	public class Inquilino
	{

		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre es obligatorio.")]
		[StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres.")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El apellido es obligatorio.")]
		[StringLength(50, ErrorMessage = "El apellido no puede tener más de 50 caracteres.")]
		public string Apellido { get; set; }

		[Required(ErrorMessage = "El teléfono es obligatorio.")]
		[Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
		public string Telefono { get; set; }

		[Required(ErrorMessage = "El correo electrónico es obligatorio.")]
		[EmailAddress(ErrorMessage = "El correo electrónico no tiene un formato válido.")]
		public string Email { get; set; }
        public int IdPropiedad { get; set; }
		public Propiedad Propiedad { get; set; }
		public ICollection<Contrato> Contratos { get; set; }
	}
}
