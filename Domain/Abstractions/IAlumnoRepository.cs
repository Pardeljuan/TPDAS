using Application.Queries;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public interface IAlumnoRepository
    {
        Task<Alumno?> ObtenerPorIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<AlumnoDTO>> ListarAsync(CancellationToken cancellationToken = default);
    }
}
