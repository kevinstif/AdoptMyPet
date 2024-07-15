using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using AdoptMyPetBackend.Pets.Domain.Repositories;
using AdoptMyPetBackend.Pets.Domain.Services;
using AdoptMyPetBackend.Pets.Domain.Services.Communiaction;
using AdoptMyPetBackend.Shared.Domain.Repositories;

namespace AdoptMyPetBackend.Pets.Application.Services
{
    public class PetTypeService : IPetTypeService
    {
        private readonly IPetTypeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public PetTypeService(IPetTypeRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<PetTypeResponse> SaveAsync(PetType petType)
        {
            try
            {
                petType.Name = petType.Name.ToLower();
                var exist = await _repository.FindByName(petType.Name);  

                if (exist is not null) return new PetTypeResponse("This Type already exist");

                await _repository.AddAsync(petType);
                await _unitOfWork.CompleteAsync();
                return new PetTypeResponse(petType);

            }catch (Exception ex)
            {
                return new PetTypeResponse(ex.Message);
            }
        }

        public async Task<PetType> GetByIdAsync(int id)
        {
            return await _repository.FindById(id);
        }

    }
}
