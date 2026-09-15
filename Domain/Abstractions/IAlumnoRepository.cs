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
        Task<Alumno> GetByIdAsync(Guid id);
        Task AddAsync(Alumno alumno);
        Task UpdateAsync(Alumno alumno);
        Task DeleteAsync(Guid id);
    }
}
