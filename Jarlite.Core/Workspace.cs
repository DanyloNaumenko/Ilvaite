namespace Jarlite.Core;

public class Workspace
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public List<Topic> Topics { get; set; } = new List<Topic>();
}