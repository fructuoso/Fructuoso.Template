using $ext_safeprojectname$.Domain.Core.Entity;
using $ext_safeprojectname$.Domain.Core.Interfaces.Repository;
using $ext_safeprojectname$.Domain.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace $ext_rootnamespace$.$safeprojectname$
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

        public async Task<ICollection<Instrutor>> GetAllInstrutorAsync(Guid id) => await _Repository.GetAllInstrutorAsync(id);
        
        public async Task<Instrutor> GetInstrutorAsync(Guid id, Guid instrutorId) => await _Repository.GetInstrutorAsync(id, instrutorId);

        public async Task<Curso> DeleteInstrutorAsync(Guid id, Guid instrutorId) => await _Repository.DeleteInstrutorAsync(id, instrutorId);
    }
}
