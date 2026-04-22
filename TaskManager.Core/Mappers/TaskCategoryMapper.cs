using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Adapters.DTOs;
using TaskManager.Core.Entities;
using TaskManager.Core.Models.TaskCategory;

namespace TaskManager.Adapters.Mappers
{
    public class TaskCategoryMapper
    {
        public static TaskCategoryDTO EntityToDTO(TaskCategoryEntity entity)
        {
            return new TaskCategoryDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
        }

        public static TaskCategoryEntity ModelToEntity(CreateTaskCategoryModel model)
        {
            // O construtor de TaskCategoryEntity espera (Guid userId, string name)
            // Como o userId não está presente no model, assumimos que será atribuído posteriormente
            // Para evitar criar uma entidade com userId inválido, lançamos exceção se necessário.
            // No entanto, para compatibilidade mínima, criaremos com Guid.Empty. O UseCase deve corrigir isso.
            return new TaskCategoryEntity(Guid.Empty, model.Name);
        }
    }
}
