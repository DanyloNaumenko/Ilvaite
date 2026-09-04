using Jarlite.Application.Auth;

namespace Jarlite.Core.User;

public class LoginIdentity
{
    public Guid Id { get; init; }
    
    public Guid UserId { get; set; }
    
    public LoginProvider LoginProvider { get; set; }

    public string Subject { get; set; } = null!;

}