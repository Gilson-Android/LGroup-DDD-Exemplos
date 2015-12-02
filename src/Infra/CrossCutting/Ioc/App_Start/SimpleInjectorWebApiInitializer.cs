using LGroup.Arquitetura.DDD.Data.EF.Repositories;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
using SimpleInjector;

namespace Ioc
{
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
            container.Register<IPessoaRepository, PessoaRepository>(life);
        }
    }
}