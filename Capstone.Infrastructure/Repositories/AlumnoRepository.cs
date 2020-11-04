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

        public async Task<Alumno> GetAlumno(int id)
        {
            var alumno = await _context.Alumno.FirstOrDefaultAsync(x=> x.IdAlumno == id);
            return alumno;
        }

        public async Task RegistrarAlumno(Alumno alumno)
        {
            _context.Alumno.Add(alumno);
            await _context.SaveChangesAsync();
        }
    }
}
