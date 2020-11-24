namespace Capstone.Core.Entities
{
    public partial class Trabajo
    {
        public int IdTrabajo { get; set; }
        public int? IdAlumno { get; set; }
        public int? IdProfesor { get; set; }
        public int? IdCurso { get; set; }
        public int EstadoTrabajo { get; set; }
        public decimal NotaTrabajo { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Profesor IdProfesorNavigation { get; set; }
    }
}
