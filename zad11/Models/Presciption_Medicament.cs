using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace zad11.Models
{
	public class Presciption_Medicament
	{
		public int IdMedicament { get; set; }
		public int IdPresciption { get; set; }
		
		public int? Dose { get; set; }

		[MaxLength]
		[Required]
		public string Details { get; set; }

		[ForeignKey("IdMedicament")]
		public Medicament Medicament { get; set; }

		[ForeignKey("IdPresciption")]
		public Presciption Presciption { get; set; }
	}
}
