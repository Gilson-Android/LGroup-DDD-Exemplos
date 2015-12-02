using System.Net;
using System.Net.Http;
using System.Web.Http;
using LGroup.Arquitetura.DDD.Domain.Contracts.Repositories;
using LGroup.Arquitetura.DDD.Domain.Entities;
using LGroup.Arquitetura.DDD.Domain.ValueObjects;

namespace UI.WebApi.Controllers
{
    [RoutePrefix("api/Pessoa")]
    public class PessoaController : ApiController
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        [Route("seila")]
        public HttpResponseMessage Get()
        {
            _pessoaRepository.Add(new PessoaEntity(30, "Natalia", SexoValueObject.Feminino));
            return Request.CreateResponse(HttpStatusCode.OK, "Funcionou");
        }
    }
}
