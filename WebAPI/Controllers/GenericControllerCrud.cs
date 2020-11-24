using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public abstract class GenericControllerCrud<TKey, TEntity> : ControllerBase where TKey : struct where TEntity : BaseEntity<TKey>
    {
        private readonly IServiceCrud<TKey, TEntity> _Service;

        protected GenericControllerCrud(IServiceCrud<TKey, TEntity> service)
        {
            _Service = service;
        }

        [HttpGet]
        public Task<IActionResult> Get() => Task.FromResult<IActionResult>(Ok(_Service.GetAllAsync()));

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(TKey id) => Ok(await _Service.GetAsync(id));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TEntity model) => Ok(await _Service.AddAsync(model));

        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] TEntity model) => Ok(await _Service.UpdateAsync(model));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(TKey id) => Ok(await _Service.DeleteAsync(id));
    }
}