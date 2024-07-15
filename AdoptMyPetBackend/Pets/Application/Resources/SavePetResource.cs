using System.ComponentModel.DataAnnotations;

namespace AdoptMyPetBackend.Pets.Application.Resources
{
    public class SavePetResource
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Image { get; set; }

        [Required]
        public int PetTypeId { get; set; }
    }
}
