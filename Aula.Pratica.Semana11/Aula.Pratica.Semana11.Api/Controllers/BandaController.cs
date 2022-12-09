using Aula.Pratica.Semana11.Api.Dto;
using Aula.Pratica.Semana11.Api.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aula.Pratica.Semana11.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandaController : ControllerBase
    {
        private readonly IMapper _mapper;

        public BandaController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("BandaCompleta")]
        public ActionResult<List<BandaAtivaDto>> BandaCompleta()
        {
            //Simular Lista de Bandas Models
            List<BandaModels> lista = new List<BandaModels>();
            lista.Add(new BandaModels { Id = 1, Nome = "Jamil e Uma noites", Album = "Meia noite", DataCriacao = DateTime.Now, Ativa = true });
            lista.Add(new BandaModels { Id = 2, Nome = "Jamil e duas noites", Album = "Meio dia", DataCriacao = DateTime.Now.AddYears(-1), Ativa = true });
            lista.Add(new BandaModels { Id = 3, Nome = "Jamil e tres noites", Album = "Sem Dormir", DataCriacao = DateTime.Now.AddYears(-20), Ativa = false });

            //Filtro de bandas Ativas
            var listaBandaAtivas = lista.Where(w => w.Ativa == true).ToList();

            //Automapper dos dados
            // Passo 1 - Instalações dos pacotes - ok
            // Passo 2 - Configuração e Injecção do AutoMapper no program.cs - ok
            // Passo 3 - Configuração do Profile e Mapeamento das classes (object-to-object) - ok 
            // Passo 4 - Injeção de Dependencia do IMapper na classe BandaController dentro do construtor - ok
            // Passo 5 - Mapping da classe BandaModels para BandaAtivaDto - ok

            List<BandaAtivaDto> listaReturns = _mapper.Map<List<BandaAtivaDto>>(listaBandaAtivas);

            return Ok(listaReturns);
        }

        [HttpGet("BandaCompletaComPessoas")]
        public ActionResult<List<BandaAtivaDto>> BandaCompletaComPessoas()
        {
            List<BandaPessoaModels> listaBandaPessoaModelsBandaUm = new List<BandaPessoaModels>();
            List<BandaPessoaModels> listaBandaPessoaModelsBandaDois = new List<BandaPessoaModels>();
            List<BandaPessoaModels> listaBandaPessoaModelsBandaTres = new List<BandaPessoaModels>();

            //Id 1 da BandaModels
            listaBandaPessoaModelsBandaUm.Add(new BandaPessoaModels { Id = 50, Nome = "pessoa 1", Vocal = false, Instrumento = "Sanfona" });
            listaBandaPessoaModelsBandaUm.Add(new BandaPessoaModels { Id = 51, Nome = "pessoa 2", Vocal = true });

            //Id 2 da BandaModels
            listaBandaPessoaModelsBandaDois.Add(new BandaPessoaModels { Id = 52, Nome = "pessoa 3", Vocal = true, Instrumento = "Guitarra" });
            listaBandaPessoaModelsBandaDois.Add(new BandaPessoaModels { Id = 53, Nome = "pessoa 4", Vocal = false, Instrumento = "Piano" });
            listaBandaPessoaModelsBandaDois.Add(new BandaPessoaModels { Id = 54, Nome = "pessoa 5", Vocal = false, Instrumento = "Guitarra" });


            //Id 3 da BandaModels
            listaBandaPessoaModelsBandaTres.Add(new BandaPessoaModels { Id = 55, Nome = "pessoa 6", Vocal = true });


            //Simular Lista de Bandas Models
            List<BandaModels> lista = new List<BandaModels>();
            lista.Add(new BandaModels { Id = 1, Nome = "Jamil e Uma noites", Album = "Meia noite", DataCriacao = DateTime.Now, Ativa = true, BandaPessoaModels = listaBandaPessoaModelsBandaUm }) ;
            lista.Add(new BandaModels { Id = 2, Nome = "Jamil e duas noites", Album = "Meio dia", DataCriacao = DateTime.Now.AddYears(-1), Ativa = true, BandaPessoaModels = listaBandaPessoaModelsBandaDois } );
            lista.Add(new BandaModels { Id = 3, Nome = "Jamil e tres noites", Album = "Sem Dormir", DataCriacao = DateTime.Now.AddYears(-20), Ativa = false, BandaPessoaModels = listaBandaPessoaModelsBandaTres });


            //Filtro de bandas Ativas
            var listaBandaAtivas = lista.Where(w => w.Ativa == true).ToList();

            //Automapper dos dados
            // Passo 1 - Instalações dos pacotes - ok
            // Passo 2 - Configuração e Injecção do AutoMapper no program.cs - ok
            // Passo 3 - Configuração do Profile e Mapeamento das classes (object-to-object) - ok 
            // Passo 4 - Injeção de Dependencia do IMapper na classe BandaController dentro do construtor - ok
            // Passo 5 - Mapping da classe BandaModels para BandaAtivaDto - ok

            List<BandaAtivaDto> listaReturns = _mapper.Map<List<BandaAtivaDto>>(listaBandaAtivas);

            return Ok(listaReturns);
        }

    }
}
