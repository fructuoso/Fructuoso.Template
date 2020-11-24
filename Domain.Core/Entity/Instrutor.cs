using System;

namespace Fructuoso.Template.Domain.Core.Entity
{
    public class Instrutor : BaseEntity<Guid>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
