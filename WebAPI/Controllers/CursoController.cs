using AutoMapper;
using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models.Instrutor;

namespace WebAPI.Controllers
{
    [ApiController]
    public class CursoController : GenericControllerCrud<Guid, Curso, CursoModel>
    {
        private readonly ICursoService _Service;

        public CursoController(
            IServiceCrud<Guid, Curso> crudService,
            ICursoService service,
            IMapper mapper) : base(crudService, mapper)
        {
            _Service = service;
        }

        [HttpGet("{id}/Instrutores")]
        public async Task<IActionResult> GetInstrutores(Guid id)
        {
            IEnumerable<Instrutor> entities = await _Service.GetAllInstrutoresAsync(id);
            IEnumerable<InstrutorModel> models = _Mapper.Map<IEnumerable<InstrutorModel>>(entities);
            return Ok(models);
        }

        [HttpPost("{id}/Instrutores")]
        public async Task<IActionResult> PostInstrutor(Guid id, [FromBody] Guid instrutorId)
        {
            await _Service.AddInstrutorAsync(id, instrutorId);
            return Ok();
        }
        [HttpDelete("{id}/Instrutores")]
        public async Task<IActionResult> DeleteInstrutor(Guid id, [FromBody] Guid instrutorId)
        {
            await _Service.DeleteInstrutorAsync(id, instrutorId);
            return Ok();
        }
    }
}
