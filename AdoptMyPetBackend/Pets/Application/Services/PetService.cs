using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Pets.Domain.Repositories;
using AdoptMyPetBackend.Pets.Domain.Services;
using AdoptMyPetBackend.Pets.Domain.Services.Communiaction;
using AdoptMyPetBackend.Shared.Domain.Repositories;
using System.Collections;
using ZstdSharp.Unsafe;

namespace AdoptMyPetBackend.Pets.Application.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _repository;
        private readonly IPetTypeRepository _typeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PetService(IPetRepository repository, IUnitOfWork unitOfWork, IPetTypeRepository typeRepository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _typeRepository = typeRepository;
        }

        public async Task<PetResponse> AddAsync(Pet pet)
        {
            try
            {
                var type = await _typeRepository.FindById(pet.PetTypeId);
                if (type is null) return new PetResponse("Type not must be null");

                await _repository.SaveAsync(pet);
                await _unitOfWork.CompleteAsync();
                return new PetResponse(pet);

            }catch (Exception ex)
            {
                return new PetResponse(ex.Message);
            }
        }

        public async Task<IEnumerable<Pet>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
