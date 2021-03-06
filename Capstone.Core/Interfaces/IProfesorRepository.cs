﻿using Capstone.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Capstone.Core.Interfaces
{
    public interface IProfesorRepository
    {
        Task<IEnumerable<Profesor>> GetProfesores();
        Task<Profesor> GetProfesor(int id);
        Task RegistrarProfesor(Profesor profesor);

    }
}
