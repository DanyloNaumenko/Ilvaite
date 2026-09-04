namespace Jarlite.Core.User;

public class User
{
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; init; }

    public List<Workspace> Workspaces { get; set; } = new List<Workspace>();
    public List<LoginIdentity> LoginIdentities { get; set; } = new List<LoginIdentity>();
}