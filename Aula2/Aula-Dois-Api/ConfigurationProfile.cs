using AutoMapper;
using Models;

namespace AulaDoisApi
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<Source, Destination>();
        }
    }
}
