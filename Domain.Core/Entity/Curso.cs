using System;
using System.Collections.Generic;

namespace Fructuoso.Template.Domain.Core.Entity
{
    public class Curso : BaseEntity<Guid>
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public virtual ICollection<Instrutor> Instrutores { get; set; }
    }
}
