namespace LGroup.Arquitetura.DDD.Domain.Entities.Core
{
    public abstract class Entity<T> 
    {
        public T Codigo { get; protected set; }
    }
}
