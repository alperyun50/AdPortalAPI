using DataModels = AdPortalAPI.DataModels;
using AdPortalAPI.DomainModels;
using AutoMapper;

namespace AdPortalAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>().ReverseMap();

            CreateMap<DataModels.Gender, Gender>().ReverseMap();

            CreateMap<DataModels.Address, Address>().ReverseMap();
        }
    }
}
