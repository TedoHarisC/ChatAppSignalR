using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public static int group_user = 0;

        public void Send(string name, string message)
        {
            Clients.All.addMessageToPage(name, message);
        }

        public void JoinGroup(string name)
        {
            Clients.All.addMessageJoin(name);
        }

        public void Count()
        {
            group_user += 1;
            Clients.All.showGroupUser(group_user);
        }
    }
}