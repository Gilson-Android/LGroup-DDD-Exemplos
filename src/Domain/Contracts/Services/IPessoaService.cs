using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Domain.Contracts.Services
{
    public interface IPessoaService
    {
        void Add(PessoaEntity pessoa);
    }
}
