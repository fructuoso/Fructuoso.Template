using AutoMapper;
using Entity = $ext_rootnamespace$.Domain.Core.Entity;

namespace $ext_rootnamespace$.$safeprojectname$.Models.Curso
{
    public class CursoProfile : Profile
    {
        public CursoProfile()
        {
            CreateMap<Entity.Curso, CursoModel>();
            CreateMap<CursoModel, Entity.Curso>();
        }
    }
}
