using Fructuoso.Template.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fructuoso.Template.Domain.Core.Interfaces.Service
{
    public interface ICursoService
    {
        Task<Curso> AddInstrutorAsync(Guid id, Guid instrutorId);
        Task<ICollection<Instrutor>> GetAllInstrutorAsync(Guid id);
        Task<Instrutor> GetInstrutorAsync(Guid id, Guid instrutorId);
        Task<Curso> DeleteInstrutorAsync(Guid id, Guid instrutorId);
    }
}
