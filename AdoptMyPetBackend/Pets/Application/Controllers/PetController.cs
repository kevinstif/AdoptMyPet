using AdoptMyPetBackend.Pets.Application.Resources;
using AdoptMyPetBackend.Pets.Domain.Model.Entities;
using AdoptMyPetBackend.Pets.Domain.Services;
using AdoptMyPetBackend.Shared.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdoptMyPetBackend.Pets.Application.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("/api/v1/[controller]")]
    public class PetController:ControllerBase
    {
        private readonly IPetService _petService;
        private readonly IMapper _mapper;

        public PetController(IPetService petService, IMapper mapper)
        {
            _petService = petService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PetResource>> GetAllAsync()
        {
            var pets = await _petService.GetAllAsync();

            return _mapper.Map<IEnumerable<Pet>,IEnumerable<PetResource>>(pets);
        }

        [HttpPost]
        public async Task<IActionResult> createPet([FromBody] SavePetResource resource)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var pet = _mapper.Map<SavePetResource,Pet>(resource);

            var result = await _petService.AddAsync(pet);

            if (!result.Success) return BadRequest(result.Message);

            var petResource = _mapper.Map<Pet, PetResource>(result.Resource);

            return Ok(petResource);
        }
    }
}
