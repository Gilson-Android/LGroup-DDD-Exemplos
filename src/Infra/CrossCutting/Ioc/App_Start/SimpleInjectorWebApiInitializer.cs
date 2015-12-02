using LGroup.Arquitetura.DDD.Data.EF.Context;
using LGroup.Arquitetura.DDD.Data.EF.Repositories;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
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
        }
     
        private static void InitializeContainer(Container container, Lifestyle life)
        {
            // For instance:
            // Toda vez que for Chamado via construtor o IPessoaRepository
            // Será instanciado o PessoaRepository..
            container.Register<IPessoaRepository, PessoaRepository>(life);
        }
    }
}