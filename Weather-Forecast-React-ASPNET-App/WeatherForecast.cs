using System;

namespace Weather_Forecast_React_ASPNET_App
{
    public class WeatherForecast //este es el modelo de datos que pasan para atrás
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
