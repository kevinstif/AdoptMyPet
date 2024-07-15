using AdoptMyPetBackend.Pets.Domain.Model.Entities;

namespace AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs
{
    public class PetType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pet> Pets { get; set; } = [];
    }
}
