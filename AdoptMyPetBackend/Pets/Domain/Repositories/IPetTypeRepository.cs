using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;

namespace AdoptMyPetBackend.Pets.Domain.Repositories
{
    public interface IPetTypeRepository
    {
        Task AddAsync(PetType type);
        Task<PetType> FindById(int id);
        Task<PetType> FindByName(string name);
    }
}
