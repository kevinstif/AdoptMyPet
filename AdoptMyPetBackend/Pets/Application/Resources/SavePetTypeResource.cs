using System.ComponentModel.DataAnnotations;

namespace AdoptMyPetBackend.Pets.Application.Resources
{
    public class SavePetTypeResource
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
