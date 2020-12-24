using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public  async Task helloWorld(string name, string message)
        {
           await Clients.All.goodByeWorld(name, message);
            //Clients.
        }
    }
}