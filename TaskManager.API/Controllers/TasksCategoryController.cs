using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Facades;

namespace TaskManager.API.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/tasksCategory")]
    public class TasksCategoryController : Controller
    {

        private readonly TaskUseCaseFacade _taskUseCaseFacade;
        public TasksCategoryController(TaskUseCaseFacade taskUseCaseFacade)
        {
            _taskUseCaseFacade = taskUseCaseFacade;
        }

 

    }
}
