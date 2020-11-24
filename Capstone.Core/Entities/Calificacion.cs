using System;
using System.Collections.Generic;

namespace Capstone.Core.Entities
{
    public partial class Calificacion
    {
        public int IdCalificacion { get; set; }
        public int? IdAlumno { get; set; }
        public int? IdProfesor { get; set; }
        public int? IdCurso { get; set; }
        public int EstadoCalificacion { get; set; }
        public decimal ValorCalificacion { get; set; }

        public virtual Alumno IdAlumnoNavigation { get; set; }
        public virtual Curso IdCursoNavigation { get; set; }
        public virtual Profesor IdProfesorNavigation { get; set; }
    }
}
