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
    public class CreateTaskPort : ICreateTaskPort
    {
        public async Task<SimpleResponseModel> Execute(TaskEntity Entity)
        {
            SimpleResponseModel Response = new SimpleResponseModel();
            try
            {

            }
            catch (Exception ex)
            {

            }
            return Response;
        }
    }
}
