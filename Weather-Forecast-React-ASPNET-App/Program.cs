using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Weather_Forecast_React_ASPNET_App
{
    public class Program
    {
        public static void Main(string[] args)  //Punto de entrada a la aplicacion
        {
            CreateWebHostBuilder(args).Build().Run(); //Crea la asp .net core app (el host vaya), lo construye y luego lo correrá
        }
        //sale 1 referencia porque justamente se llama arriba a este método (está referenciado)
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>(); //la clase Startup.cs
    }
}
