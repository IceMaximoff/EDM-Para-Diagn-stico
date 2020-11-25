using AutoMapper;
using Capstone.Core.DTOs;
using Capstone.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Alumno, AlumnoDto>();
            CreateMap<AlumnoDto, Alumno>();
        }
    }
}
