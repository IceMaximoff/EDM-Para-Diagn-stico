﻿using System.Collections.Generic;

namespace Capstone.Core.Entities
{
    public partial class Profesor
    {
        public Profesor()
        {
            Calificacion = new HashSet<Calificacion>();
            Examen = new HashSet<Examen>();
            PruebaEce = new HashSet<PruebaEce>();
            Trabajo = new HashSet<Trabajo>();
        }

        public int IdProfesor { get; set; }
        public string NombresProfesor { get; set; }
        public string ApellidosProfesor { get; set; }
        public int EdadProfesor { get; set; }
        public int EstadoProfesor { get; set; }

        public virtual ICollection<Calificacion> Calificacion { get; set; }
        public virtual ICollection<Examen> Examen { get; set; }
        public virtual ICollection<PruebaEce> PruebaEce { get; set; }
        public virtual ICollection<Trabajo> Trabajo { get; set; }
    }
}
