using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Repository;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fructuoso.Template.Domain.Services
{
    public class CursoService : GenericServiceCrud<Guid, Curso>, ICursoService
    {
        public readonly ICursoRepository _Repository;

        public CursoService(
            IRepositoryCrud<Guid, Curso> crudRepository,
            ICursoRepository repository) : base(crudRepository)
        {
            _Repository = repository;
        }

        public async Task<Curso> AddInstrutorAsync(Guid id, Guid instrutorId) => await _Repository.AddInstrutorAsync(id, instrutorId);

        public async Task<ICollection<Instrutor>> GetAllInstrutoresAsync(Guid id) => await _Repository.GetAllInstrutoresAsync(id);

        public async Task<Curso> DeleteInstrutorAsync(Guid id, Guid instrutorId) => await _Repository.DeleteInstrutorAsync(id, instrutorId);
    }
}
