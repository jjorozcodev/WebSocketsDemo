using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSocketDemoTime.WebSocketCode
{
    /// <summary>
    /// Summary description for TimeHandler
    /// </summary>
    public class TimeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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