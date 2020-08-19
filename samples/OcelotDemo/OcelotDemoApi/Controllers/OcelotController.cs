//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;

//namespace OcelotDemoApi.Controllers
//{
//    //[ApiController]
//    [Route("api/[controller]")]
//    public class OcelotController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        private readonly ILogger<OcelotController> _logger;

//        public OcelotController(ILogger<OcelotController> logger)
//        {
//            _logger = logger;
//        }

//        [HttpGet]
//        public IEnumerable<WeatherForecast> Get()
//        {
//            var rng = new Random();
//            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//            {
//                Date = DateTime.Now.AddDays(index),
//                TemperatureC = rng.Next(-20, 55),
//                Summary = Summaries[rng.Next(Summaries.Length)]
//            })
//            .ToArray();
//        }

//        [HttpGet("{Id}")]
//        public async Task<IActionResult> Get(int Id)
//        {
//            var result = await Task.Run(() =>
//            {
//                return $"This is from {HttpContext.Request.Host.Value}, path: {HttpContext.Request.Path}";
//            });
//            return Ok(result);
//        }
//    }
//}
