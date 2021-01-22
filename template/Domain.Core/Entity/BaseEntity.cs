namespace $ext_rootnamespace$.$safeprojectname$.Entity
{
    public abstract class BaseEntity<T> where T : struct
    {
        public T Id { get; set; }
    }
}
