using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zad11.Models
{
	public class DoctorsDbContext : DbContext
	{
		public DbSet<Medicament> Medicaments { get; set; }
		public DbSet<Presciption_Medicament> Presciption_Medicaments { get; set; }
		public DbSet<Presciption> Presciptions { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DoctorsDbContext()
		{

		}

		public DoctorsDbContext(DbContextOptions options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Presciption_Medicament>()
				.HasKey(z => new { z.IdMedicament, z.IdPresciption });

			modelBuilder.Entity<Medicament>(e =>
			{
				e.HasData(new Medicament { IdMedicament=1, Name = "1", Description = "1", Type = "1" });
				e.HasData(new Medicament { IdMedicament = 2, Name = "2", Description = "2", Type = "2" });
				e.HasData(new Medicament { IdMedicament = 3, Name = "3", Description = "3", Type = "3" });
			});

			modelBuilder.Entity<Presciption>(e =>
			{
				e.HasData(new Presciption { IdPresciption=1, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(50), IdPatient = 1, IdDoctor = 1 });
				e.HasData(new Presciption { IdPresciption = 2, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(50), IdPatient = 2, IdDoctor = 2 });
				e.HasData(new Presciption { IdPresciption = 3, Date = DateTime.Now, DueDate = DateTime.Now.AddDays(50), IdPatient = 3, IdDoctor = 3 });
			});

			modelBuilder.Entity<Presciption_Medicament>(e =>
			{
				e.HasData(new Presciption_Medicament { IdMedicament = 1, IdPresciption = 1, Details = "1" });
				e.HasData(new Presciption_Medicament { IdMedicament = 2, IdPresciption = 2, Details = "2" });
				e.HasData(new Presciption_Medicament { IdMedicament = 3, IdPresciption = 3, Details = "3" });
			});

			modelBuilder.Entity<Patient>(e =>
			{
				e.HasData(new Patient { IdPatient=1, FirstName = "1", LastName = "1", BirthDate = DateTime.Now });
				e.HasData(new Patient { IdPatient = 2, FirstName = "2", LastName = "2", BirthDate = DateTime.Now });
				e.HasData(new Patient { IdPatient = 3, FirstName = "3", LastName = "3", BirthDate = DateTime.Now });
			});

			modelBuilder.Entity<Doctor>(e => {
				e.HasData(new Doctor { IdDoctor=1, FirstName = "1", LastName = "1", Email = "1@gmail.com" });
				e.HasData(new Doctor { IdDoctor = 2, FirstName = "2", LastName = "2", Email = "2@gmail.com" });
				e.HasData(new Doctor { IdDoctor = 3, FirstName = "3", LastName = "3", Email = "3@gmail.com" });
			});
        }
	}
}
