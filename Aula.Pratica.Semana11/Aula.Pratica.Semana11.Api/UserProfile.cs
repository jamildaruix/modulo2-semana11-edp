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
            CreateMap<BandaModels, BandaAtivaDto>();

            //Mapeamento entre nossa DTO para MODEL
            CreateMap<BandaAtivaDto, BandaModels>();
        }
    }
}
