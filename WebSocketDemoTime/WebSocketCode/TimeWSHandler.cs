using Microsoft.Web.WebSockets;
using System;

namespace WebSocketDemoTime.WebSocketCode
{
    public class TimeWSHandler : WebSocketHandler
    {
        public override void OnOpen()
        {
            base.OnOpen();
            PoolWebSocket.AddClient(this);
            this.Send("Connected at " + DateTime.Now.ToString());
        }
        
        public override void OnClose()
        {
            base.OnClose();
            PoolWebSocket.RemoveClient(this);
        }
    }
}