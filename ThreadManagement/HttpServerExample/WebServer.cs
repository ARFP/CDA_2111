using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpServerExample
{
    public class WebServer
    {
        Boolean running;
        HttpListener server;

        public async void Start()
        {
            using (server = new HttpListener())
            {
                server.Prefixes.Add("http://localhost:8000/");
                server.Start();
                running = true;

                while(running)
                {
                    var context = await server.GetContextAsync();

                    Thread t = new Thread(OnRequest);
                    t.Start(context);
                }
            }
        }

        public void Stop()
        {
            running = false;
        }

        public void OnRequest(object request)
        {
            if(request is HttpListenerContext ctx)
            {
                string r = "<html>Bonjour !</html>";

                byte[] rep = Encoding.UTF8.GetBytes(r.ToCharArray());

                ctx.Response.Close(rep, true);
            }
        }
    }
}
