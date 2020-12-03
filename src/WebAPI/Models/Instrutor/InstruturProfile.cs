using AutoMapper;
using Entity = Fructuoso.Template.Domain.Core.Entity;

namespace WebAPI.Models.Instrutor
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
