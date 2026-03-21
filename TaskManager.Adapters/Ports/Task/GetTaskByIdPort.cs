using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.Ports.Task;
using TaskManager.Core.ResposePattern;
using TaskManager.Core.UseCases.Task.Interfaces;

namespace TaskManager.Adapters.Persistence.Task
{
    public class GetTaskByIdPort : IGetTaskByIdPort
    {
        public Task<ResponseModel<TaskEntity>> ExecuteAsync(Guid TaskId, Guid UserId)
        {
            throw new NotImplementedException();
        }
    }
}
