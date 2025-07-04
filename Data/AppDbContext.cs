using Microsoft.EntityFrameworkCore;
using GestionCursosApi.Models;

namespace GestionCursosApi.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		public DbSet<Curso> Cursos { get; set; }
		public DbSet<Docente> Docentes { get; set; }
	}
}
