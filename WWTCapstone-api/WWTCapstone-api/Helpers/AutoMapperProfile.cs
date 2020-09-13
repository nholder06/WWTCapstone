using AutoMapper;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<Pet, User>();
        }
    }
}
