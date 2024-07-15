using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Shared.Domain.Services.Communications;

namespace AdoptMyPetBackend.Pets.Domain.Services.Communiaction
{
    public class PetResponse : BaseResponse<Pet>
    {
        public PetResponse(string message) : base(message)
        {
        }

        public PetResponse(Pet resource) : base(resource)
        {
        }
    }
}
