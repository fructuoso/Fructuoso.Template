using AutoMapper;
using Entity = $ext_rootnamespace$.Domain.Core.Entity;

namespace $ext_rootnamespace$.$safeprojectname$.Models.Instrutor
{
    public class InstrutorProfile : Profile
    {
        public InstrutorProfile()
        {
            CreateMap<Entity.Instrutor, InstrutorModel>();
            CreateMap<InstrutorModel, Entity.Instrutor>();
        }
    }
}
