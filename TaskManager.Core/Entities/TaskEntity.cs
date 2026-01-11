using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Enums;

namespace TaskManager.Core.Entities
{
    public class TaskEntity
    {

        public TaskEntity(string name, string? description, Guid categoryId, Guid userId)
        {
            Id= Guid.NewGuid();
            Name = name;
            Description = description;
            this.CategoryId = categoryId;
            UserId = userId;
            StatusEnum =TaskStatusEnum.NotStarted;
            CreatedAt=DateTime.Now;
        }

        public TaskEntity(string? name, string? description, TaskStatusEnum newStatus)
        {
            Name= name;
            Description= description;
            StatusEnum= newStatus;
            UpdatedAt= DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public Guid UserId { get; set; }
        public UserEntity User { get; private set; }
        public Guid CategoryId { get; private set; }
        public TaskCategoryEntity Category { get; private set; }
        public TaskStatusEnum StatusEnum { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; } 

    }
}
