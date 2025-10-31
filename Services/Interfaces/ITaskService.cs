using ProjectManagerApi.DTOs;
using ProjectManagerApi.Models;

namespace ProjectManagerApi.Services.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetTasksByProject(Guid projectId);
        TaskItem AddTask(Guid projectId, DTOs.Tasks.TaskDto dto);
        TaskItem UpdateTask(Guid taskId, DTOs.Tasks.TaskDto dto);
        void DeleteTask(Guid taskId);
    }
}
