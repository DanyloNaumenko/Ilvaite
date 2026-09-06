namespace Jarlite.Application.Auth.Abstractions;

public interface IAuthenticationProvider
{
    public string Authenticate();
}