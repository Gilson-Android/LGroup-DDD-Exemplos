using System;
using LGroup.Arquitetura.DDD.Data.EF.Context;
using LGroup.Arquitetura.DDD.Domain.Contracts.UnityOfWork;
using Microsoft.Practices.ServiceLocation;

namespace LGroup.Arquitetura.DDD.Data.EF.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        private PessoaContext _pessoaContext;

        public void Begin()
        {
            _pessoaContext = ServiceLocator.Current.GetInstance<PessoaContext>();
        }

        public void SaveChanges()
        {
            _pessoaContext.SaveChanges();
        }
    }
}
