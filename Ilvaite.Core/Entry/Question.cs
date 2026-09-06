namespace Jarlite.Core.Entry;

public class Question: Entry
{
    public Question()
    {
        base.Type = EntryType.Question;
    }
    public string Answer { get; init; } = string.Empty;
}