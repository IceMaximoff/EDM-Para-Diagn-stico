using Capstone.Core.Interfaces;
using Capstone.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Capstone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IAlumnoRepository _alumnoRepository;
        public AlumnoController(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAlumnos()
        {
            var alumnos = await _alumnoRepository.GetAlumnos();
            return Ok(alumnos);
        }
    }
}
