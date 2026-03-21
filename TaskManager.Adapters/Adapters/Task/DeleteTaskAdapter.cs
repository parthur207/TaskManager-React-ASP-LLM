using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.Mappers;
using TaskManager.Core.Enums;
using TaskManager.Core.Ports.Task;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Adapters.Persistence.Task
{
    public class DeleteTaskAdapter : IDeleteTaskPort
    {
        private readonly DbContextTaskManager _contextTask;
        public DeleteTaskAdapter(DbContextTaskManager contextTask)
        {
            _contextTask = contextTask;
        }

        public async Task<SimpleResponseModel> ExecuteAsync(Guid IdTask, Guid IdUser)
        {
            var Response= new SimpleResponseModel();
            try
            {
                var taskMapped= TaskMapper.

                if (taskMapped is null)
                {
                    Response.Message = "Erro no mapeamento.";
                    Response.Status= ResponseStatusEnum.Error;
                    return Response;
                }

                var resultRepository = await _contextTask.Task.ExecuteDeleteAsync(taskMapped, IdUser);



            }
            catch (Exception ex)
            {

            }

            throw new NotImplementedException();
        }
    }
}
