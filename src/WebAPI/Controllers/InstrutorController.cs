using AutoMapper;
using Fructuoso.Template.Domain.Core.Entity;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI.Models.Instrutor;

namespace WebAPI.Controllers
{
    [ApiController]
    public class InstrutorController : GenericControllerCrud<Guid, Instrutor, InstrutorModel>
    {
        public InstrutorController(
            IServiceCrud<Guid, Instrutor> service,
            IMapper mapper) : base(service, mapper) { }
    }
}
