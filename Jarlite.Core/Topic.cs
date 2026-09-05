namespace Jarlite.Core;

public class Topic
{
    public Guid Id { get; init; }
    public Guid WorkspaceId { get; set; }
    
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public List<Entry.Entry> Entries { get; set; } = new List<Entry.Entry>();
}