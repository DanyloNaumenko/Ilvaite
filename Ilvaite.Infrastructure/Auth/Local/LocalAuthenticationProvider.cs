using Jarlite.Application.Auth.Abstractions;

namespace Ilvaite.Infrastructure.Auth.Local;

public class LocalAuthenticationProvider : IAuthenticationProvider
{
    private readonly PasswordCredential _passwordCredential;

    public LocalAuthenticationProvider(PasswordCredential passwordCredential)
    {
        _passwordCredential = passwordCredential;
    }

    public string Authenticate()
    {
        throw new NotImplementedException();
    }
}