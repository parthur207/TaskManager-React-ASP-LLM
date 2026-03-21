using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Entities;
using TaskManager.Core.Ports.Task;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Adapters.Persistence.Task
{
    public class UpdateTaskDetailsAdapter : IUpdateTaskDetailsPort
    {
        public Task<SimpleResponseModel> ExecuteAsync(TaskEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
