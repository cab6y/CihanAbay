using Microsoft.AspNetCore.SignalR;

namespace CihanAbay
{
    public class ChatHub : Hub
    {
        public void SendMessage(string user, string message)
        {
             Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
