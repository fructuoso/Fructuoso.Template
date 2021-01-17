using System;
using FluentValidation;

namespace $ext_rootnamespace$.$safeprojectname$.Models.Curso
{
    public class CursoModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
    }

    public class CursoModelValidator : AbstractValidator<CursoModel>
    {
        public CursoModelValidator()
        {
            RuleFor(model => model.Nome).NotNull();
            RuleFor(model => model.CargaHoraria).NotEqual(0);
        }
    }
}
