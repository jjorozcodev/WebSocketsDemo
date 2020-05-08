using Microsoft.Web.WebSockets;
using System.Web;

namespace WebSocketDemoTime.WebSocketCode
{
    public class TimeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(new TimeWSHandler());
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}