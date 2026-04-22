using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.Mappers;
using TaskManager.Core.Entities;
using TaskManager.Core.Enums;
using TaskManager.Core.Models.Task;
using TaskManager.Core.Ports.Security;
using TaskManager.Core.Ports.Task;
using TaskManager.Core.ResposePattern;

namespace TaskManager.Adapters.Persistence.Task
{
    public class CreateTaskAdapter : ICreateTaskPort
    {
        private readonly DbContextTaskManager _context;
        private readonly ICurrentUserPort _currentUserPort;
        public CreateTaskAdapter(DbContextTaskManager context, ICurrentUserPort currentUserPort)
        {
            _context = context;
            _currentUserPort = currentUserPort;
        }

        public async Task<SimpleResponseModel> ExecuteAsync(TaskEntity entity)
        {
            var Response = new SimpleResponseModel();
            try
            {
                if (entity is null)
                {
                    Response.Status= ResponseStatusEnum.Error;
                    Response.Message="Ocorreu um erro. Entidade inválida/nula";
                    return Response;
                }

                await _context.Task.AddAsync(entity);
                await _context.SaveChangesAsync();

                Response.Status = ResponseStatusEnum.Success;
                Response.Message = "Tarefa criada com sucesso.";
                return Response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }
}
