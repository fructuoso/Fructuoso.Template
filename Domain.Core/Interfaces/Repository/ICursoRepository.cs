using Fructuoso.Template.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fructuoso.Template.Domain.Core.Interfaces.Repository
{
    public interface ICursoRepository
    {
        Task<Curso> AddInstrutorAsync(Guid id, Guid instrutorId);
        Task<ICollection<Instrutor>> GetAllInstrutoresAsync(Guid id);
        Task<Curso> DeleteInstrutorAsync(Guid id, Guid instrutorId);

    }
}
