using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionCursosApi.Data;
using GestionCursosApi.Models;

namespace GestionCursosApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DocentesController : ControllerBase
	{
		private readonly AppDbContext _context;

		public DocentesController(AppDbContext context)
		{
			_context = context;
		}

		// GET: api/Docentes
		[HttpGet]
		public async Task<ActionResult<IEnumerable<Docente>>> GetDocentes()
		{
			return await _context.Docentes.ToListAsync();
		}

		// POST: api/Docentes
		[HttpPost]
		public async Task<ActionResult<Docente>> PostDocente(Docente docente)
		{
			_context.Docentes.Add(docente);
			await _context.SaveChangesAsync();

			return CreatedAtAction(nameof(GetDocentes), new { id = docente.Id }, docente);
		}
	}
}
