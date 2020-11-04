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
    }
}
