using System.Collections.Generic;
namespace Capstone.Core.Entities
{
    public partial class Alumno
    {
        public Alumno()
        {
            Calificacion = new HashSet<Calificacion>();
            Examen = new HashSet<Examen>();
            PruebaEce = new HashSet<PruebaEce>();
            Trabajo = new HashSet<Trabajo>();
        }

        public int IdAlumno { get; set; }
        public string NombresAlumno { get; set; }
        public string ApellidosAlumno { get; set; }
        public int EdadAlumno { get; set; }
        public int EstadoAlumno { get; set; }

        public virtual ICollection<Calificacion> Calificacion { get; set; }
        public virtual ICollection<Examen> Examen { get; set; }
        public virtual ICollection<PruebaEce> PruebaEce { get; set; }
        public virtual ICollection<Trabajo> Trabajo { get; set; }
    }
}
