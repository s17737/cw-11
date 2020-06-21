using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace zad11.Models
{
	public class Presciption
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdPresciption { get; set; }

		public DateTime Date { get; set; }
		public DateTime DueDate { get; set; }
		public int IdPatient { get; set; }
		public int IdDoctor { get; set; }
		public ICollection<Presciption_Medicament> Presciption_Medicaments { get; set; }

		[ForeignKey("IdDoctor")]
		public Doctor Doctor { get; set; }

		[ForeignKey("IdPatient")]
		public Patient Patient { get; set; }

	}
}
