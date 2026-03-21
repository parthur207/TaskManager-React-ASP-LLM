using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.DTOs;
using TaskManager.Core.Entities;
using TaskManager.Core.Models;

namespace TaskManager.Adapters.Mappers
{
    public class TaskMapper
    {
        public TaskEntity ModelToEntity(CreateTaskModel model)
        {
            return new TaskEntity
                (
                    Name: "",
                    Description: "",
                    CategoryId: Guid.NewGuid(),
                    UserId: Guid.NewGuid()
                );
        }

        public TaskDTO EntityToDTO(TaskEntity entity)
        {
            return new TaskDTO
                (
                    : entity.Name,
                    Description: entity.Description,
                    CategoryId: entity.CategoryId,
                    UserId: entity.UserId,
                    StatusEnum: entity.StatusEnum
                );
        }
    }
}
