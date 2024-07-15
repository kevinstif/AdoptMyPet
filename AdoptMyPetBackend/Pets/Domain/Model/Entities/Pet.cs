using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;

namespace AdoptMyPetBackend.Pets.Domain.Model.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set;}
        public int PetTypeId { get; set; }
        public PetType Type { get; set; } = null!;
    }
}
