namespace ProjectManagerApi.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public DateTime? DueDate { get; set; }

        public Guid ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
