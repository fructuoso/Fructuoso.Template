using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Repository;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fructuoso.Template.Domain.Services
{
    public class GenericServiceCrud<TKey, TEntity> : IServiceCrud<TKey, TEntity> where TKey : struct where TEntity : BaseEntity<TKey>
    {
        private readonly IRepositoryCrud<TKey, TEntity> _Repository;

        public GenericServiceCrud(IRepositoryCrud<TKey, TEntity> repository)
        {
            _Repository = repository;
        }

        public async Task<TEntity> AddAsync(TEntity obj) => await _Repository.AddAsync(obj);
        public async Task<TEntity> DeleteAsync(TKey id) => await _Repository.DeleteAsync(id);
        public async Task<TEntity> GetAsync(TKey id) => await _Repository.GetAsync(id);
        public IAsyncEnumerable<TEntity> GetAllAsync() => _Repository.GetAllAsync();
        public async Task<TEntity> UpdateAsync(TEntity obj) => await _Repository.UpdateAsync(obj);
    }
}
