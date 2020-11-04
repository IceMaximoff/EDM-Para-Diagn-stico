using Capstone.Core.Entities;
using Capstone.Core.Interfaces;
using Capstone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Infrastructure.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly CapstoneDBContext _context;
        public AlumnoRepository(CapstoneDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Alumno>> GetAlumnos()
        {
            var alumnos = await _context.Alumno.ToListAsync();
            
            return alumnos;
        }
    }
}
