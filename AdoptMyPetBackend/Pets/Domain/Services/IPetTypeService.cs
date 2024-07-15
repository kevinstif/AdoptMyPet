using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using AdoptMyPetBackend.Pets.Domain.Services.Communiaction;

namespace AdoptMyPetBackend.Pets.Domain.Services
{
    public interface IPetTypeService
    {
        Task<PetTypeResponse> SaveAsync(PetType petType);
        Task<PetType> GetByIdAsync(int id);
    }
}
