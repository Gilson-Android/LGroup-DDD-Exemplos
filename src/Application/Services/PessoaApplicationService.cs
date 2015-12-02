using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Arquitetura.DDD.Application.Contracts.Core;
using LGroup.Arquitetura.DDD.Application.Contracts.Services;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Application.Services
{
    public class PessoaApplicationService : ApplicationBase, IPessoaApplicationService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaApplicationService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Add(PessoaEntity pessoa)
        {
            Begin();
            // Adicionar Usuário
            // Mandar Email
            // Gravar Log
            _pessoaRepository.Add(pessoa);
            SaveChanges();
        }
    }
}
