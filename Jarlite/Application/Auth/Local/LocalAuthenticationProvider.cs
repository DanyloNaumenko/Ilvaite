namespace Jarlite.Application.Auth.Local;

public class LocalAuthenticationProvider
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