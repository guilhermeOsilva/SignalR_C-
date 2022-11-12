using System;
using Microsoft.AspNetCore.SignalR;


namespace SignalR.Hubs
{
    public class PollHub: Hub
    {
        public async Task SendMessage(string user, string message, string myChannelId, string myChannelVal)
        {
            await Clients.All.SendAsync("ReceiveMessae", user, message, myChannelVal).ConfigureAwait(false);
        }
    }
}
