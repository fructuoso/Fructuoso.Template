using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fructuoso.Template.Infra.Repository
{
    public class CursoRepository : GenericRepositoryCrud<Guid, Curso>, ICursoRepository
    {
        public CursoRepository(RepositoryContext context) : base(context) { }

        public async Task<Curso> AddInstrutorAsync(Guid id, Guid instrutorId)
        {
            Curso curso = await _DbSet.Include(o => o.Instrutores).FirstOrDefaultAsync(o => o.Id.Equals(id));
            Instrutor instrutor = await _Context.Set<Instrutor>().FirstOrDefaultAsync(o => o.Id.Equals(instrutorId));

            if (curso == null) return null;
            if (instrutor == null) return null;

            curso.Instrutores.Add(instrutor);
            await UpdateAsync(curso);

            return curso;
        }

        public async Task<Curso> DeleteInstrutorAsync(Guid id, Guid instrutorId)
        {
            Curso curso = await _DbSet.Include(o => o.Instrutores).FirstOrDefaultAsync(o => o.Id.Equals(id));

            if (curso == null) return null;

            Instrutor instrutor = curso.Instrutores.FirstOrDefault(o => o.Id.Equals(instrutorId));

            if (instrutor == null) return null;

            curso.Instrutores.Remove(instrutor);
            await UpdateAsync(curso);

            return curso;
        }

        public async Task<ICollection<Instrutor>> GetAllInstrutorAsync(Guid id)
        {
            Curso curso = await _DbSet.Include(o => o.Instrutores).FirstOrDefaultAsync(o => o.Id.Equals(id));
            return curso?.Instrutores;
        }
        public async Task<Instrutor> GetInstrutorAsync(Guid id, Guid instrutorId)
        {
            Curso curso = await _DbSet.Include(o => o.Instrutores).FirstOrDefaultAsync(o => o.Id.Equals(id));
            return curso?.Instrutores.FirstOrDefault(o => o.Id.Equals(instrutorId));
        }
    }
}
