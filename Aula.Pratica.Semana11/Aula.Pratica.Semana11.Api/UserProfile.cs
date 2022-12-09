using Aula.Pratica.Semana11.Api.Dto;
using Aula.Pratica.Semana11.Api.Models;
using AutoMapper;

namespace Aula.Pratica.Semana11.Api
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            //Mapeamento entre nossa MODEL para DTO
            CreateMap<BandaModels, BandaAtivaDto>()
                .ForMember(dto => dto.AnoBanda, act => act.MapFrom(model => model.DataCriacao.Year))
                .ForMember(dto => dto.BandaPessoaVocalDtos, act => act.MapFrom(model => model.BandaPessoaModels));

            //Mapeamento entre nossa DTO para MODEL
            CreateMap<BandaAtivaDto, BandaModels>();

            //Mapemaneto entre BandaPessoaModels para BandaPessoaVocalDto
            CreateMap<BandaPessoaModels, BandaPessoaVocalDto>()
                .ForMember(dto => dto.NomeDaPessoa, act => act.MapFrom(model => model.Nome.ToUpper()));
        }
    }
}
