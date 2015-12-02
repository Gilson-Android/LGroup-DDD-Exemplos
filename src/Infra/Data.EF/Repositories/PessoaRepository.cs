using System.CodeDom;
using LGroup.Arquitetura.DDD.Data.EF.Context;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
using System;
using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Data.EF.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContext _pessoaContext;

        public PessoaRepository(PessoaContext pessoaContext)
        {
            _pessoaContext = pessoaContext;
        }

        public void Add(PessoaEntity pessoa)
        {
            _pessoaContext.PessoaEntities.Add(pessoa);
        }
    }
}
