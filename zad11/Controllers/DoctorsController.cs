using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zad11.Models;

namespace zad11.Controllers
{
	[Route("api/doctors")]
	[ApiController]
	public class DoctorsController : ControllerBase
	{
		private readonly DoctorsDbContext _contex;
		public DoctorsController(DoctorsDbContext context)
		{
			_contex = context;
		}

		[HttpGet]
		public IActionResult GetDoctors()
		{
			ICollection<Doctor> Doctors;
			Doctors = _contex.Doctors.ToList();
			
			return Ok(Doctors);
		}

		[HttpGet]
		public IActionResult GetDoctors(int IdDoctor)
		{
			//ICollection<Doctor> Doctors;
			foreach (var i in _contex.Doctors)
			{
				if (i.IdDoctor==IdDoctor)
				{
					return Ok(i);
				}
				else
				{
					 return BadRequest("doctor doesnt exist");
				}
			}

			return Ok();
		}
	}
}
