using CommonServiceLocator.SimpleInjectorAdapter;
using LGroup.Arquitetura.DDD.Application.Contracts.Services;
using LGroup.Arquitetura.DDD.Application.Services;
using LGroup.Arquitetura.DDD.Data.EF.Context;
using LGroup.Arquitetura.DDD.Data.EF.Repositories;
using LGroup.Arquitetura.DDD.Data.EF.UnityOfWork;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
using LGroup.Arquitetura.DDD.Domain.Contracts.UnityOfWork;
using Microsoft.Practices.ServiceLocation;
using SimpleInjector;

namespace Ioc
{
    // É um Framework analogo ao Ninject
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize(this Container container, Lifestyle life)
        {
            InitializeContainer(container, life);

            // Irá colocar o container do SimpleInjector no ServiceLocator
            ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
        }
     
        private static void InitializeContainer(Container container, Lifestyle life)
        {
            // For instance:
            // Toda vez que for Chamado via construtor o IPessoaRepository
            // Será instanciado o PessoaRepository..
            container.Register<IPessoaRepository, PessoaRepository>(life);
            container.Register<IPessoaApplicationService, PessoaApplicationService>();
            container.Register<IUnityOfWork, UnityOfWork>();
            container.Register<PessoaContext>();
        }
    }
}