﻿using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.Identity;
using CourseProject.Services.Contracts;

namespace CourseProject.Web.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IUsersService usersService;

        public ChatHub(IUsersService usersService)
        {
            if (usersService == null)
            {
                throw new ArgumentNullException("usersService");
            }

            this.usersService = usersService;
        }

        public void Connect(string username)
        {
            string name = this.Context.User.Identity.GetUserName();
            var groupName = $"{name}_{username}";
            Groups.Add(Context.ConnectionId, groupName);
        }

        public void Disconnect(string username)
        {
            string name = this.Context.User.Identity.GetUserName();
            var groupName = $"{name}_{username}";
            Groups.Remove(Context.ConnectionId, groupName);
        }

        public void CheckUsernameAndConnect(string username)
        {
            var exists = this.usersService.CheckIfUserExists(username);

            if (exists)
            {
                this.Connect(username);
                Clients.Caller.ChatWith(username);
            }
            else
            {
                Clients.Caller.ShowUsernameError(username);
            }
        }

        public void SendMessage(string username, string message)
        {
            var callerName = this.Context.User.Identity.GetUserName();
            message = HttpUtility.HtmlEncode(message);
            var receiverGroupName = $"{username}_{callerName}";
            Clients.Group(receiverGroupName).AddChatMessage(callerName, message);
        }
    }
}