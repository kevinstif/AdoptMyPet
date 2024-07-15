namespace AdoptMyPetBackend.Pets.Application.Resources
{
    public class PetResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int PetTypeId {  get; set; }
    }
}
