using Jarlite.Core.EntryTypes;

namespace Jarlite.Core;

public abstract class Entry
{
    public Guid Id { get; init; }
    public Guid TopicId { get; set; }
    
    public string Title { get; init; } = string.Empty;
    public string Content { get; init; } = string.Empty;
    public int Confidence { get; set; }
    public EntryType Type { get; init; }
    public List<string> Tags { get; set; } = new List<string>();
    
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastReviewedAt { get; set; } = DateTime.UtcNow;
}