namespace LGroup.Arquitetura.DDD.Domain.Contracts.UnityOfWork
{
    public interface IUnityOfWork
    {
        void Begin();
        void SaveChanges();
    }
}
