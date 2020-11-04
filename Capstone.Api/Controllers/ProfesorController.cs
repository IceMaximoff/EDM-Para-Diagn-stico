using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Core.Entities;
using Capstone.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorRepository _profesorRepository;

        public ProfesorController(IProfesorRepository profesorRepository)
        {
            _profesorRepository = profesorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfesores()
        {
            var profesores = await _profesorRepository.GetProfesores();
            return Ok(profesores);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfesor(int id)
        {
            var profesor = await _profesorRepository.GetProfesor(id);
            return Ok(profesor);
        }
        [HttpPost]
        public async Task<IActionResult> RegistrarProfesor(Profesor profesor)
        {
            await _profesorRepository.RegistrarProfesor(profesor);
            return Ok(profesor);
        }
    }
}
