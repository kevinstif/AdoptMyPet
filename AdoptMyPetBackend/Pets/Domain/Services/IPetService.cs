using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Pets.Domain.Services.Communiaction;

namespace AdoptMyPetBackend.Pets.Domain.Services
{
    public interface IPetService
    {
        Task<PetResponse> AddAsync(Pet pet);
        Task<IEnumerable<Pet>> GetAllAsync();
    }
}
