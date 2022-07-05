using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HttpServerExample
{
    public class WebServer
    {
        public Boolean Running { get; private set; }
        HttpListener server;

        public async void Start()
        {
            using (server = new HttpListener())
            {
                server.Prefixes.Add("http://localhost:8000/");
                server.Start();
                Running = true;

                while(Running)
                {
                    var context = await server.GetContextAsync();

                    Thread t = new Thread(OnRequest);
                    t.Start(context);
                }
            }
        }

        public void Stop()
        {
            Running = false;
        }

        public void OnRequest(object? request)
        {
            if(request is HttpListenerContext ctx) 
            {
                // string r = "<html>Bonjour !</html>";
                List<Car> cars = Car.getCars();

                string json = JsonSerializer.Serialize(cars);

                // List<Car> newCars = JsonSerializer.Deserialize<List<Car>>(json);

                byte[] rep = Encoding.UTF8.GetBytes(json.ToCharArray());

                ctx.Response.Close(rep, true);
            }
        }
    }
}
