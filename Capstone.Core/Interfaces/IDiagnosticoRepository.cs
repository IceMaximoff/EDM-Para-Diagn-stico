using Capstone.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Core.Interfaces
{
    public interface IDiagnosticoRepository
    {
        Task<DiagnosticoDto> GetDiagnostico(AlumnoDataDto alumnoDataDto);
    }
}
