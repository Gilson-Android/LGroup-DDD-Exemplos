using System.Net;
using System.Net.Http;
using System.Web.Http;
using LGroup.Arquitetura.DDD.Application.Contracts.Services;
using LGroup.Arquitetura.DDD.Domain.Entities;
using LGroup.Arquitetura.DDD.Domain.ValueObjects;

namespace UI.WebApi.Controllers
{
    [RoutePrefix("api/Pessoa")]
    public class PessoaController : ApiController
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;

        public PessoaController(IPessoaApplicationService pessoaApplicationService)
        {
            _pessoaApplicationService = pessoaApplicationService;
        }

        [HttpGet]
        [Route("seila")]
        public HttpResponseMessage Get()
        {
            _pessoaApplicationService.Add(new PessoaEntity(30, "Maria", SexoValueObject.Feminino));

            return Request.CreateResponse(HttpStatusCode.OK, "Funcionou");
        }
    }
}
