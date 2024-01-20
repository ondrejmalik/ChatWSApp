namespace BlazorApp2.Shared;

public class Credentials
{
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsLoggedIn { get; set; } = false;
}