namespace Fructuoso.Template.Domain.Core.Entity
{
    public abstract class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }
    }
}
