using AdoptMyPetBackend.Shared.Domain.Repositories;
using AdoptMyPetBackend.Shared.Persistence.Context;

namespace AdoptMyPetBackend.Shared.Persistence.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
