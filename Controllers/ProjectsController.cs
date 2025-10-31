using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectManagerApi.DTOs;
using ProjectManagerApi.Services.Interfaces;
using System.Security.Claims;

namespace ProjectManagerApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService) => _projectService = projectService;

        [HttpGet]
        public IActionResult GetProjects()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            return Ok(_projectService.GetProjects(userId));
        }

        [HttpPost]
        public IActionResult CreateProject(ProjectDto dto)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var project = _projectService.CreateProject(userId, dto);
            return Ok(project);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProject(Guid id)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            _projectService.DeleteProject(userId, id);
            return NoContent();
        }
    }
}
