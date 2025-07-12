namespace GestionCursosApi.Models
{
	public class Docente
	{
		public int Id { get; set; }
		public string Apellidos { get; set; }
		public string Nombres { get; set; }
		public string Profesion { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public string Correo { get; set; }

		// Solución: inicializamos con una lista vacía
		public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
	}
}
