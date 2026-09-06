namespace Jarlite.Core.User;

public class LoginIdentity
{
    public Guid Id { get; init; }
    
    public Guid UserId { get; set; }

    public LoginProviderId Provider { get; set; } = null!;

    public string Subject { get; set; } = null!;

}