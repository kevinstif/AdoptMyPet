using AdoptMyPetBackend.Shared.Persistence.Context;

namespace AdoptMyPetBackend.Shared.Persistence.Repositories
{
    public class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
