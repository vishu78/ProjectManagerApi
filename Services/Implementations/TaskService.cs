using ProjectManagerApi.Data;
using ProjectManagerApi.DTOs;
using ProjectManagerApi.Models;
using ProjectManagerApi.Services.Interfaces;

namespace ProjectManagerApi.Services.Implementations
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TaskItem> GetTasksByProject(Guid projectId)
        {
            return _context.Tasks.Where(t => t.ProjectId == projectId).ToList();
        }

        public TaskItem AddTask(Guid projectId, DTOs.Tasks.TaskDto dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                DueDate = dto.DueDate,
                IsCompleted = dto.IsCompleted,
                ProjectId = projectId
            };
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return task;
        }

        public TaskItem UpdateTask(Guid taskId, DTOs.Tasks.TaskDto dto)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null) throw new Exception("Task not found");

            task.Title = dto.Title;
            task.DueDate = dto.DueDate;
            task.IsCompleted = dto.IsCompleted;
            _context.SaveChanges();
            return task;
        }

        public void DeleteTask(Guid taskId)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task == null) throw new Exception("Task not found");

            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
