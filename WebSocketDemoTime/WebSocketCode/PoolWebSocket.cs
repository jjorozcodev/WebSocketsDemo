using Microsoft.Web.WebSockets;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WebSocketDemoTime.WebSocketCode
{
    public static class PoolWebSocket
    {
        private static WebSocketCollection clients;

        static PoolWebSocket()
        {
            clients = new WebSocketCollection();

            Task.Run(() => UpdateTime());
        }

        private static void UpdateTime()
        {
            while (true)
            {
                foreach(TimeWSHandler c in clients)
                {
                    c.Send("Time now is: " + DateTime.Now.ToString());
                }

                Thread.Sleep(5000); // Refresh every 5 seconds...
            }
        }

        public static void AddClient(TimeWSHandler wsClient)
        {
            clients.Add(wsClient);
        }

        public static void RemoveClient(TimeWSHandler wsClient)
        {
            clients.Remove(wsClient);
        }
    }
}