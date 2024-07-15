using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using AdoptMyPetBackend.Shared.Domain.Services.Communications;

namespace AdoptMyPetBackend.Pets.Domain.Services.Communiaction
{
    public class PetTypeResponse : BaseResponse<PetType>
    {
        public PetTypeResponse(string message) : base(message)
        {
        }

        public PetTypeResponse(PetType resource) : base(resource)
        {
        }
    }
}
