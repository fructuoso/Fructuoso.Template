using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Fructuoso.Template.Infra.Repository
{
    public class GenericRepositoryCrud<TKey, TEntity> : IRepositoryCrud<TKey, TEntity> where TKey : struct where TEntity : BaseEntity<TKey>
    {
        protected readonly RepositoryContext _Context;
        protected readonly DbSet<TEntity> _DbSet;

        public GenericRepositoryCrud(RepositoryContext context)
        {
            _Context = context;
            _DbSet = _Context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            _DbSet.Add(obj);
            await _Context.SaveChangesAsync();
            return obj;
        }
        public async Task<TEntity> DeleteAsync(TKey id)
        {
            var obj = await _DbSet.FirstOrDefaultAsync(o => o.Id.Equals(id));

            if (obj == null) return null;

            _DbSet.Remove(obj);
            await _Context.SaveChangesAsync();

            return obj;
        }
        public async Task<TEntity> GetAsync(TKey id) => await _DbSet.FirstOrDefaultAsync(o => o.Id.Equals(id));
        public IAsyncEnumerable<TEntity> GetAllAsync() => _DbSet.AsAsyncEnumerable();
        public async Task<TEntity> UpdateAsync(TEntity obj)
        {
            if (!await _DbSet.AnyAsync(o => o.Id.Equals(obj.Id))) return null;

            _Context.Entry(obj).State = EntityState.Modified;
            await _Context.SaveChangesAsync();
            return obj;
        }

    }
}