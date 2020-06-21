﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace zad11.Models
{
	public class Doctor
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdDoctor { get; set; }

		[MaxLength(100)]
		[Required]
		public string FirstName { get; set; }

		[MaxLength(100)]
		[Required]
		public string LastName { get; set; }

		[MaxLength(100)]
		[Required]
		public string Email { get; set; }

		public ICollection<Presciption> Presciptions { get; set; }
	}
}
