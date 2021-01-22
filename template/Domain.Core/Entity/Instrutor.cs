using System;
using System.Collections.Generic;

namespace $ext_rootnamespace$.$safeprojectname$.Entity
{
    public class Instrutor : BaseEntity<Guid>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
