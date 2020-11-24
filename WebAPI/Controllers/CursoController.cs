using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controllers
{
    [ApiController]
    public class CursoController : GenericControllerCrud<Guid, Curso>
    {
        public CursoController(IServiceCrud<Guid, Curso> service) : base(service) { }
    }
}
