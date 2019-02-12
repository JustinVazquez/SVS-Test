using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace monari.WebApi.Hubs
{
    public class MainHub: Hub
    {
        public string Send(int p1)
        {
            return "Stundenplan Test: " + p1;
        }


        public void Send2()
        {
            Clients.All.SendAsync("test3");
        }
    }
}
