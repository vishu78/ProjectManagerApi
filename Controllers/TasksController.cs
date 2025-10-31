using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectManagerApi.DTOs;
using ProjectManagerApi.Services.Interfaces;

namespace ProjectManagerApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TasksController(ITaskService taskService) => _taskService = taskService;

        [HttpGet("project/{projectId}")]
        public IActionResult GetTasks(Guid projectId) => Ok(_taskService.GetTasksByProject(projectId));

        [HttpPost("project/{projectId}")]
        public IActionResult AddTask(Guid projectId, DTOs.Tasks.TaskDto dto) => Ok(_taskService.AddTask(projectId, dto));

        [HttpPut("{taskId}")]
        public IActionResult UpdateTask(Guid taskId, DTOs.Tasks.TaskDto dto) => Ok(_taskService.UpdateTask(taskId, dto));

        [HttpDelete("{taskId}")]
        public IActionResult DeleteTask(Guid taskId)
        {
            _taskService.DeleteTask(taskId);
            return NoContent();
        }
    }
}
