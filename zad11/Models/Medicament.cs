using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace zad11.Models
{
	public class Medicament
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdMedicament { get; set; }

		[MaxLength(100)]
		[Required]
		public string Name { get; set; }
		[MaxLength(100)]
		[Required]
		public string Description { get; set; }

		[MaxLength(100)]
		[Required]
		public string Type { get; set; }

		public ICollection<Presciption_Medicament> Presciption_Medicaments { get; set; }

	}
}
