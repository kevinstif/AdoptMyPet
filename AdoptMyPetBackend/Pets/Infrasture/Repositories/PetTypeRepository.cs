using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using AdoptMyPetBackend.Pets.Domain.Repositories;
using AdoptMyPetBackend.Shared.Persistence.Context;
using AdoptMyPetBackend.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AdoptMyPetBackend.Pets.Infrasture.Repositories
{
    public class PetTypeRepository : BaseRepository, IPetTypeRepository
    {
        public PetTypeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AddAsync(PetType type)
        {
            await _context.types.AddAsync(type);
        }

        public async Task<PetType> FindById(int id)
        {
            return await _context.types.FindAsync(id);
        }

        public async Task<PetType> FindByName(string name)
        {
            return await _context.types.FirstOrDefaultAsync(p=>p.Name == name);
        }
    }
}
