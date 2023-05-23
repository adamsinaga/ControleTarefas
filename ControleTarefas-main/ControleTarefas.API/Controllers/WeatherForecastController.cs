using Microsoft.AspNetCore.Mvc;

namespace ControleTarefas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            var weather1 = new WeatherForecast();
            weather1.Date = DateTime.Now;
            weather1.Summary =  "Teste weather1";
            weather1.TemperatureC = 40;

            var weather2 = new WeatherForecast();
            weather2.Date = DateTime.Now.AddDays(20);
            weather2.Summary = "Teste weather2";
            weather2.TemperatureC = 40;

            var weather3 = new WeatherForecast();
            weather3.Date = DateTime.Now.AddDays(50);
            weather3.Summary = "Teste weather3";
            weather3.TemperatureC = 40;

            var lista = new List<WeatherForecast>();
            lista.Add(weather1);
            lista.Add(weather2);
            lista.Add(weather3);

            return lista;


        }
    }
}