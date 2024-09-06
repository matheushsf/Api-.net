using System;
using System.Web.Http;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;
using CorsOptions = Microsoft.Owin.Cors.CorsOptions;

class Program
{
    static void Main(string[] args)
    {
        string baseAddress = "http://localhost:9000/";

        using (WebApp.Start<Startup>(url: baseAddress))
        {
            Console.WriteLine("API rodando em " + baseAddress);
            Console.ReadLine();
        }
    }
}

public class Startup
{
    public void Configuration(IAppBuilder appBuilder)
    {

        appBuilder.UseCors(CorsOptions.AllowAll);

        HttpConfiguration config = new HttpConfiguration();
        config.Routes.MapHttpRoute(
        name: "DefaultApi",
        routeTemplate: "api/{controller}/{id}",
        defaults: new { id = RouteParameter.Optional }
        );


        appBuilder.UseWebApi(config);
    }
}
