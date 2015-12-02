namespace LGroup.Arquitetura.DDD.Domain.Contracts.Repositories.Core
{
    public interface IAddRepository<T> where T : class
    {
        void Add(T entity);
    }
}
