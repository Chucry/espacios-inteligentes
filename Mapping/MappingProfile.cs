using AutoMapper;
using WebDev.Controllers.Resources;
using WebDev.Models;

namespace WebDev.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Empleado, EmpleadoResource>();
            CreateMap<Departamento, DepartamentoResource>();
        }
    }
}
