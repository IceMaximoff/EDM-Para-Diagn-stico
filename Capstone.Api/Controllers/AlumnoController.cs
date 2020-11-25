using AutoMapper;
using Capstone.Core.DTOs;
using Capstone.Core.Entities;
using Capstone.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoRepository _alumnoRepository;
        private readonly IMapper _mapper;
        public AlumnoController(IAlumnoRepository alumnoRepository, IMapper mapper)
        {
            _alumnoRepository = alumnoRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAlumnos()
        {
            var alumnos = await _alumnoRepository.GetAlumnos();
            var alumnosDto = _mapper.Map<IEnumerable<AlumnoDto>>(alumnos);
            return Ok(alumnosDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlumno(int id)
        {
            var alumno = await _alumnoRepository.GetAlumno(id);
            var alumnoDto = _mapper.Map<AlumnoDto>(alumno);
            return Ok(alumnoDto);
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarAlumno(AlumnoDto alumnoDto)
        {
            var alumno = _mapper.Map<Alumno>(alumnoDto);
            await _alumnoRepository.RegistrarAlumno(alumno);
            return Ok(alumno);
        }

        


    }
}
