namespace Capstone.Core.Entities
{
    public partial class PruebaEce
    {
        public int IdEce { get; set; }
        public int? IdAlumno { get; set; }
        public int? IdProfesor { get; set; }
        public int? IdCurso { get; set; }
        public int EstadoEce { get; set; }
        public decimal PuntajeEce { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Profesor IdProfesorNavigation { get; set; }
    }
}
