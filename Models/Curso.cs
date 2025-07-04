namespace GestionCursosApi.Models
{
	public class Curso
	{
		public int Id { get; set; }
		public string NombreCurso { get; set; }
		public int Creditos { get; set; }
		public int HorasSemanal { get; set; }
		public int Ciclo { get; set; }

		public int IdDocente { get; set; }
		public Docente Docente { get; set; }
	}
}
