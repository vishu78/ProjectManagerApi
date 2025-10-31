using ProjectManagerApi.DTOs;
using ProjectManagerApi.Models;

namespace ProjectManagerApi.Services.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects(Guid userId);
        Project CreateProject(Guid userId, ProjectDto dto);
        void DeleteProject(Guid userId, Guid projectId);
    }
}
