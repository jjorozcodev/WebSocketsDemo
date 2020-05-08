using Microsoft.Web.WebSockets;
using System.Web;

// Seems to be... The handler that implements "TimeWSHandler" need to be expose on root, but needs the same namespace.
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