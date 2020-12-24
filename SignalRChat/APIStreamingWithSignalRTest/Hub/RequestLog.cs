using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIStreamingWithSignalRTest
{
    public class RequestLog : Hub
    {
        public static void PostToClient(string data)
        {
            try
            {
                var chat = GlobalHost.ConnectionManager.GetHubContext("RequestLog");


                if (chat != null)
                {
                    chat.Clients.All.postToClient(data);
                }
            }
            catch(Exception e)
            {

            }
        }
    }
}