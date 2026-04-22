using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Entities
{
    public sealed class TaskCategoryEntity
    {
        public TaskCategoryEntity(Guid userId, string name)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Name = name;
            CreatedAt = DateTime.Now;
            Tasks = new List<TaskEntity>();
        }//Criar

        public Guid Id { get; private set; }
        public Guid UserId { get; private set; }
        public UserEntity? User { get; private set; }
        public IList<TaskEntity> Tasks { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; set; }

        public void UpdateCategoryName(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ArgumentNullException("O novo nome para a categoria não pode ser nulo.");
            }
            Name = newName;
            UpdatedAt = DateTime.Now;
        }

        public void AssigneTask(TaskEntity newTask)
        {
            if (newTask is null)
            {
                throw new ArgumentNullException(nameof(newTask), "Erro. Tarefa nula.");
            }
            if (Tasks.Contains(newTask))
            {
                throw new InvalidOperationException("A tarefa já está atribuída a esta categoria.");
            }
            Tasks.Add(newTask);
        }
    }
}
 