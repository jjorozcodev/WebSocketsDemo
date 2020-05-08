using Microsoft.Web.WebSockets;

namespace WebSocketDemoTime.WebSocketCode
{
    public static class PoolWebSocket
    {
        private static WebSocketCollection clients;

        static PoolWebSocket()
        {
            clients = new WebSocketCollection();
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