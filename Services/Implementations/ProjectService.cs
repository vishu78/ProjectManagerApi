using ProjectManagerApi.Data;
using ProjectManagerApi.DTOs;
using ProjectManagerApi.Models;
using ProjectManagerApi.Services.Interfaces;

namespace ProjectManagerApi.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly AppDbContext _context;

        public ProjectService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Project> GetProjects(Guid userId)
        {
            return _context.Projects.Where(p => p.UserId == userId).ToList();
        }

        public Project CreateProject(Guid userId, ProjectDto dto)
        {
            var project = new Project
            {
                Title = dto.Title,
                Description = dto.Description,
                UserId = userId
            };
            _context.Projects.Add(project);
            _context.SaveChanges();
            return project;
        }

        public void DeleteProject(Guid userId, Guid projectId)
        {
            var project = _context.Projects.FirstOrDefault(p => p.Id == projectId && p.UserId == userId);
            if (project == null) throw new Exception("Project not found");
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }
    }
}
