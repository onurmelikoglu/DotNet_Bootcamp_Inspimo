using Microsoft.AspNetCore.Http;

namespace TaskManagerServer.Domain.Entities;

public sealed class TaskManager
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateOnly FinishDate { get; set; }
    public List<string>? TaskFileUrls { get; set; }
}