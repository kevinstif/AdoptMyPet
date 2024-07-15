using AdoptMyPetBackend.Pets.Domain.Model.Entities;

namespace AdoptMyPetBackend.Pets.Domain.Repositories
{
    public interface IPetRepository
    {
        Task SaveAsync(Pet pet);
        Task<IEnumerable<Pet>> GetAllAsync();
    }
}
