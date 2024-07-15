using AdoptMyPetBackend.Pets.Application.Resources;
using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using AutoMapper;

namespace AdoptMyPetBackend.Pets.Application.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<SavePetTypeResource, PetType>();
            CreateMap<PetType, PetTypeResource>();
            CreateMap<SavePetResource, Pet>();
            CreateMap<Pet,PetResource>();
        }
    }
}
