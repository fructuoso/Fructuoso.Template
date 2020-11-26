﻿using AutoMapper;
using Entity = Fructuoso.Template.Domain.Core.Entity;

namespace WebAPI.Models.Instrutor
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
