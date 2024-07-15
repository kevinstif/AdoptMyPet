using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Pets.Domain.Repositories;
using AdoptMyPetBackend.Shared.Persistence.Context;
using AdoptMyPetBackend.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AdoptMyPetBackend.Pets.Infrasture.Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        public PetRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Pet>> GetAllAsync()
        {
            return await _context.pets.ToListAsync();
        }

        public async Task SaveAsync(Pet pet)
        {
            await _context.pets.AddAsync(pet);
        }
    }
}
