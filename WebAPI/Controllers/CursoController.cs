using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    public class CursoController : GenericControllerCrud<Guid, Curso>
    {
        private readonly ICursoService _Service;

        public CursoController(
            IServiceCrud<Guid, Curso> crudService,
            ICursoService service) : base(crudService)
        {
            _Service = service;
        }

        [HttpGet("{id}/Instrutores")]
        public async Task<IActionResult> GetInstrutores(Guid id) => Ok(await _Service.GetAllInstrutoresAsync(id));

        [HttpPost("{id}/Instrutores")]
        public async Task<IActionResult> PostInstrutor(Guid id, [FromBody] Guid instrutorId) => Ok(await _Service.AddInstrutorAsync(id, instrutorId));
        [HttpDelete("{id}/Instrutores")]
        public async Task<IActionResult> DeleteInstrutor(Guid id, [FromBody] Guid instrutorId) => Ok(await _Service.DeleteInstrutorAsync(id, instrutorId));
    }
}
