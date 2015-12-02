using LGroup.Arquitetura.DDD.Domain.Contracts.UnityOfWork;
using Microsoft.Practices.ServiceLocation;

namespace LGroup.Arquitetura.DDD.Application.Contracts.Core
{
    public abstract class ApplicationBase
    {
        private IUnityOfWork _unityOfWork;

        // Instanciar o PessoaContexto 
        public void Begin()
        {
            _unityOfWork = ServiceLocator.Current.GetInstance<IUnityOfWork>();
            _unityOfWork.Begin();
        }

        // Salvando (Commit)
        public void SaveChanges()
        {
            _unityOfWork.SaveChanges();
        }
    }
}
