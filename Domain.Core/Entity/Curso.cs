using System;

namespace Fructuoso.Template.Domain.Core.Entity
{
    public class Curso : BaseEntity<Guid>
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
    }
}
