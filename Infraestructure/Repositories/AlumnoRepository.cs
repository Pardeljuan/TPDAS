using Application.Queries;
using Domain.Abstractions;
using Domain.Entities;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public sealed class AlumnoRepository(EscuelaDbContext context) : IAlumnoRepository
    {
        public async Task<IReadOnlyList<AlumnoDTO>> ListarAsync(CancellationToken cancellationToken = default)=>
        
            await context.Alumnos
                .AsNoTracking()
                .OrderBy(a => a.Nombre)
                .Select(a => new AlumnoDTO(a.Id, a.Nombre, a.Apellido, a.Edad))
                .ToListAsync(cancellationToken);

        

        public async Task<Alumno?> ObtenerPorIdAsync(Guid id, CancellationToken cancellationToken = default)=>
        
            await context.Alumnos.FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
        
    }
}
