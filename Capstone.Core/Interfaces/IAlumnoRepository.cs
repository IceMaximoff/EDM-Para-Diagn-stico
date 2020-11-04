using Capstone.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Capstone.Core.Interfaces
{
    public interface IAlumnoRepository
    {
        Task<IEnumerable<Alumno>> GetAlumnos();
    }
}
