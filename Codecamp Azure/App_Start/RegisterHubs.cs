using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(SignalR.StockTicker.RegisterHubs), "Start")]

namespace SignalR.StockTicker
{
    public static class RegisterHubs
    {
        public static void Start()
        {
            string sbConnectStrion = @"Endpoint=sb://codecampcluj.servicebus.windows.net/;SharedSecretIssuer=owner;SharedSecretValue=uQ9rizWzBsBy1o2LgkYBUW3Ij3gQhbNX2yoA9uzj4RY=";
            GlobalHost.DependencyResolver.UseServiceBus(sbConnectStrion, "codecampcluj");

            // Register the default hubs route: ~/signalr
            RouteTable.Routes.MapHubs();
        }
    }
}
