using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Facades;
using TaskManager.Core.Enums;
using TaskManager.Core.Models.Space;

namespace TaskManager.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/spaces")]
    public class SpaceController
    {
        private readonly SpaceUseCaseFacade _spaceUseCaseFacade;

        public SpaceController(SpaceUseCaseFacade spaceUseCaseFacade)
        {
            _spaceUseCaseFacade = spaceUseCaseFacade;
        }

        [HttpGet("profile")]
        public async Task<IActionResult> GetSpacesProfile()
        {
            var spaces = await _spaceUseCaseFacade.();
            return new OkObjectResult(spaces);
        }


        //sidebar
        [HttpGet()]
        public async Task<IActionResult> GetSpacesMember()
        {
            var spaces = await _spaceUseCaseFacade.();
            return new OkObjectResult(spaces);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpaceById([FromRoute] Guid id)
        {
            var space = await _spaceUseCaseFacade.GetById.ExecuteAsync(id);
          
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpace([FromBody] CreateSpaceModel space)
        {
            var createdSpace = await _spaceUseCaseFacade.create.ExecuteAsync(space);

            switch
            {
                case ResponseStatusEnum.Success:
                    return new OkObjectResult(createdSpace);
                case ResponseStatusEnum.BadRequest:
                    return new BadRequestObjectResult(createdSpace);
                default:
                    return new ObjectResult(createdSpace) { StatusCode = 500 };
            }
    }
}