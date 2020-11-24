using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controllers
{
    [ApiController]
    public class InstrutorController : GenericControllerCrud<Guid, Instrutor>
    {
        public InstrutorController(IServiceCrud<Guid, Instrutor> service) : base(service) { }
    }
}
