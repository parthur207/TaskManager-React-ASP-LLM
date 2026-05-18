using TaskManager.Core.DTOs;

namespace TaskManager.Core.Ports.Notifications
{
    public interface ITaskNotificationPort
    {
        Task NotifyTaskCreated(Guid spaceId, TaskDTO task);
        Task NotifyTaskUpdated(Guid spaceId, TaskDTO task);
        Task NotifyTaskDeleted(Guid spaceId, Guid taskId);
    }
}