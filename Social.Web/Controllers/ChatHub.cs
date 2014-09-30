using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SocialLibrary;

namespace Social.Web.Controllers
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            // Call the broadcastMessage method to update clients.
            string userEmail = HttpContext.Current.User.Identity.Name.ToString();

            ChatMessage chatM = new ChatMessage() { Body = message, User = userEmail };

            Clients.All.broadcastMessage(chatM);
        }
    }
}