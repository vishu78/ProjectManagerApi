namespace ProjectManagerApi.Models
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
