namespace Capstone.Core.Entities
{
    public partial class Examen
    {
        public int IdExamen { get; set; }
        public int? IdAlumno { get; set; }
        public int? IdProfesor { get; set; }
        public int? IdCurso { get; set; }
        public int EstadoExamen { get; set; }
        public decimal NotaExamen { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Profesor IdProfesorNavigation { get; set; }
    }
}
