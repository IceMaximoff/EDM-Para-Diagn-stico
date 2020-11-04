using System;
using System.Collections.Generic;

namespace Capstone.Core.Entities
{
    public partial class Alumno
    {
        public int IdAlumno { get; set; }
        public string NombresAlumno { get; set; }
        public string ApellidosAlumno { get; set; }
        public int EdadAlumno { get; set; }
        public int EstadoAlumno { get; set; }
    }
}
