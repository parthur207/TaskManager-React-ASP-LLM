using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Facades;

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
    }
}
