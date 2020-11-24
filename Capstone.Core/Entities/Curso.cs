using System.Collections.Generic;

namespace Capstone.Core.Entities
{
    public partial class Curso
    {
        public Curso()
        {
            Calificacion = new HashSet<Calificacion>();
            Examen = new HashSet<Examen>();
            PruebaEce = new HashSet<PruebaEce>();
            Trabajo = new HashSet<Trabajo>();
        }

        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public int EstadoCurso { get; set; }

        public virtual ICollection<Calificacion> Calificacion { get; set; }
        public virtual ICollection<Examen> Examen { get; set; }
        public virtual ICollection<PruebaEce> PruebaEce { get; set; }
        public virtual ICollection<Trabajo> Trabajo { get; set; }
    }
}
