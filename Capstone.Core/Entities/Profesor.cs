using System;
using System.Collections.Generic;

namespace Capstone.Core.Entities
{
    public partial class Profesor
    {
        public int IdProfesor { get; set; }
        public string NombresProfesor { get; set; }
        public string ApellidosProfesor { get; set; }
        public int EdadProfesor { get; set; }
        public int EstadoProfesor { get; set; }
    }
}
