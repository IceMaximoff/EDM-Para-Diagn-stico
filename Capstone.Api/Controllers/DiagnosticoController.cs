using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Core.DTOs;
using Capstone.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capstone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosticoController : ControllerBase
    {
        private readonly IDiagnosticoRepository _diagnosticoRepository;
        public DiagnosticoController(IDiagnosticoRepository diagnosticoRepository)
        {
            _diagnosticoRepository = diagnosticoRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetDiagnostico(AlumnoDataDto alumnoDataDto)
        {
            var diagnostico = await _diagnosticoRepository.GetDiagnostico(alumnoDataDto);
            return Ok(diagnostico);
        }
    }
}
