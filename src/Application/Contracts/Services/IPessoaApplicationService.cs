using LGroup.Arquitetura.DDD.Domain.Entities;

namespace LGroup.Arquitetura.DDD.Application.Contracts.Services
{
    public interface IPessoaApplicationService
    {
        void Add(PessoaEntity pessoa);
    }
}
