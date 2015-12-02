using System;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
using LGroup.Arquitetura.DDD.Domain.Contracts.Services;
using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Add(PessoaEntity pessoa)
        {
            if (pessoa == null)
                throw new ApplicationException("É necessário informar uma pessoa");

            if (pessoa.Idade < 18)
                throw new ApplicationException("É proíbido a entrada de pessoas menores de 18 anos");

            _pessoaRepository.Add(pessoa);
        }
    }
}
