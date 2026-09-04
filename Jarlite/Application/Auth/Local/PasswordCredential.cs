using Jarlite.Core.User;

namespace Jarlite.Application.Auth.Local;

public class PasswordCredential
{
    public LoginIdentity LoginIdentity { get; set; } = null!;
    
    public string PasswordHash { get; set; } = string.Empty;
}