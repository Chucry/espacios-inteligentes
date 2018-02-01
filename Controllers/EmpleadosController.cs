using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDev.Controllers.Resources;
using WebDev.Models;
using WebDev.Persistence;

namespace WebDev.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly EIDbContext _context;
        private readonly IMapper _mapper;

        public EmpleadosController(EIDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("/api/empleados")]
        public async Task<IEnumerable<EmpleadoResource>> GetEmpleado()
        {
            var empleados = await _context.Empleado.Include(x => x.Departamento).ToListAsync();
            return  _mapper.Map<List<Empleado>, List<EmpleadoResource>>(empleados);
        }


    }
}
