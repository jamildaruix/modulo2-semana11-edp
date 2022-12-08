using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;

        public WeatherForecastController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost("AutoMapperExemplo")]
        public ActionResult<Destination> AutoMapperExemplo(Source source)
        {
            //Converter o SOURCE para DESTINATION
            Destination destination = _mapper.Map<Destination>(source);

            return Ok(destination);
        }

        [HttpGet("ExplictObjeto")]
        public ActionResult<ExplicitObjetoResponse> ExplicitObjeto()
        {
            ExplicitObjetoRequest explicitObjetoRequest = new ExplicitObjetoRequest();
            explicitObjetoRequest.Codigo = 1;
            explicitObjetoRequest.Nome = "TESTE 12345";
            explicitObjetoRequest.DataNascimento = Convert.ToDateTime("01/01/1970");

            //Conversao do objeto explicit de ExplicitObjetoRequest para ExplicitObjetoResponse
            ExplicitObjetoResponse explicitObjetoResponse = (ExplicitObjetoResponse)explicitObjetoRequest;

            return Ok(explicitObjetoResponse);
        }

        [HttpGet("ImplicitObjeto")]
        public ActionResult<ImplicitObjetoRequest> ImplicitObjeto()
        {
            ImplicitObjetoRequest implicitObjetoRequest = new ImplicitObjetoRequest();
            implicitObjetoRequest.Codigo = 1;
            implicitObjetoRequest.Nome = "TESTE 12345";
            implicitObjetoRequest.DataNascimento = Convert.ToDateTime("01/01/1970");


            //Conversao do objeto implicit de ImplicitObjetoRequest para ImplicitObjetoResponse
            ImplicitObjetoResponse implicitObjetoResponse = implicitObjetoRequest;

            return Ok(implicitObjetoResponse);
        }
    }
}