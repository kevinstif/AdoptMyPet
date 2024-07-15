using AdoptMyPetBackend.Pets.Domain.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AdoptMyPetBackend.Shared.Extensions;
using AdoptMyPetBackend.Pets.Domain.Model.ValueObjetcs;
using Swashbuckle.AspNetCore.Annotations;
using AdoptMyPetBackend.Pets.Application.Resources;

namespace AdoptMyPetBackend.Pets.Application.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("/api/v1/[controller]")]
    public class PetTypeController : ControllerBase
    {
        private readonly IPetTypeService _petTypeService;
        private readonly IMapper _mapper;

        public PetTypeController(IPetTypeService petTypeService, IMapper mapper)
        {
            _petTypeService = petTypeService;
            _mapper = mapper;
        }

        [SwaggerOperation(
            Summary = "Create New PetType",
            Description = "Create New PetType",
            Tags = new[] { "PetTypes" })]
        [HttpPost]
        public async Task<IActionResult> CreatePetType([FromBody] SavePetTypeResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var petType = _mapper.Map<SavePetTypeResource, PetType>(resource);

            var result = await _petTypeService.SaveAsync(petType);

            if (!result.Success)
                return BadRequest(result.Message);

            var petTypeResource = _mapper.Map<PetType, PetTypeResource>(result.Resource);

            return Ok(petTypeResource);
        }
    }
}
