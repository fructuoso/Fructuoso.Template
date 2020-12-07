using AutoMapper;
using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models.Curso;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<InstrutorModel>>> GetInstrutor(Guid id)
        {
            IEnumerable<Instrutor> entities = await _Service.GetAllInstrutorAsync(id);

            if (entities == null) return NotFound();

            IEnumerable<InstrutorModel> models = _Mapper.Map<IEnumerable<InstrutorModel>>(entities);
            return Ok(models);
        }

        [HttpGet("{id}/Instrutores/{instrutorId}", Name = "GetInstrutor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InstrutorModel>> GetInstrutor(Guid id, Guid instrutorId)
        {
            Instrutor entity = await _Service.GetInstrutorAsync(id, instrutorId);

            if (entity == null) return NotFound();
            
            return Ok(_Mapper.Map<InstrutorModel>(entity));
        }

        [HttpPost("{id}/Instrutores/{instrutorId}", Name = "AssociarInstrutor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> PostInstrutor(Guid id, Guid instrutorId)
        {
            await _Service.AddInstrutorAsync(id, instrutorId);
            Instrutor entity = await _Service.GetInstrutorAsync(id, instrutorId);

            string action = Url.Action("GetInstrutor", ControllerContext.ActionDescriptor.ControllerName, new { id = id, instrutorId = instrutorId });

            return Created(action, _Mapper.Map<InstrutorModel>(entity));
        }

        [HttpDelete("{id}/Instrutores/{instrutorId}", Name = "DesassociarInstrutor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteInstrutor(Guid id, Guid instrutorId)
        {
            await _Service.DeleteInstrutorAsync(id, instrutorId);
            return NoContent();
        }
    }
}
