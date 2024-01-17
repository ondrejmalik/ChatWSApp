using Realms;

namespace BlazorApp2.Shared;

public class RealmCredentials: RealmObject
{
    [PrimaryKey] 
    public string Username { get; set; }
    public string Password { get; set; }
}