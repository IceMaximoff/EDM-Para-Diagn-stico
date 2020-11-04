using Capstone.Core.Entities;
using Capstone.Core.Interfaces;
using Capstone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Infrastructure.Repositories
{
    public class ProfesorRepository : IProfesorRepository
    {
        private readonly CapstoneDBContext _context;
        public ProfesorRepository(CapstoneDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Profesor>> GetProfesores()
        {
            var profesores = await _context.Profesor.ToListAsync();
            return profesores;
        }
        public async Task<Profesor> GetProfesor(int id)
        {
            var profesor = await _context.Profesor.FirstOrDefaultAsync(x=> x.IdProfesor==id);
            return profesor;
        }
        public async Task RegistrarProfesor(Profesor profesor)
        {
            _context.Profesor.Add(profesor);
            await _context.SaveChangesAsync();
        }
    }
}
