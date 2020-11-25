using Capstone.Core.DTOs;
using Capstone.Core.Interfaces;
using Capstone.DM;
using Capstone.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Infrastructure.Repositories
{
    public class DiagnosticoRepository : IDiagnosticoRepository
    {
        private readonly CapstoneDBContext _context;
        public DiagnosticoRepository(CapstoneDBContext context)
        {
            _context = context;
        }
        public async Task<DiagnosticoDto> GetDiagnostico(AlumnoDataDto alumnoDataDto)
        {
            var diagnostico = Cluster.Diagnosticar(alumnoDataDto);
            return diagnostico;
        }
    }
}
