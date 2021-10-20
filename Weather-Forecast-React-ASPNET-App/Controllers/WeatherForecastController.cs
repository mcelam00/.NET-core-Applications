using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//Es la parte donde llega la request
namespace Weather_Forecast_React_ASPNET_App.Controllers
{
    [ApiController]
    [Route("[controller]")] //para esta ruta definen un weatherForecast (esta clase)
    public class WeatherForecastController : ControllerBase 
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get() //crean un random set de los valores de weather de arriba y lo retornan como respuesta al usuario. La clase weatherForecast está en el .cs
        {
            var rng = new Random(); //aqui se crea un objeto, que después en el return se serializa por defecto como json.
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
