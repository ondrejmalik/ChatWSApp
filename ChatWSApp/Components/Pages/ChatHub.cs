using BlazorApp2.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorApp2.Components.Pages;

public class ChatHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }
    
    public async Task SendMessage(string groupName,Message message)
    {
        try
        {
            await Clients.Group(groupName).SendAsync("ReceiveMessage", message);
        }
        catch (Exception e)
        {
            ;
        }
    }
    

    public async Task AddGroup(string groupName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        await SendMessage(groupName, new Message
        {
            User = Credentials.Username,
            Text = "has Connected"
        });
    }

}