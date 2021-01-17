using AutoMapper;
using $ext_safeprojectname$.Domain.Core.Entity;
using $ext_safeprojectname$.Domain.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using $ext_rootnamespace$.$safeprojectname$.Models.Instrutor;

namespace $ext_rootnamespace$.$safeprojectname$.Controllers
{
    [ApiController]
    public class InstrutorController : GenericControllerCrud<Guid, Instrutor, InstrutorModel>
    {
        public InstrutorController(
            IServiceCrud<Guid, Instrutor> service,
            IMapper mapper) : base(service, mapper) { }
    }
}
