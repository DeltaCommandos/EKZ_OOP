using EKZ18.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EKZ18.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Get([FromQuery] int a)
        {
            return Ok($"a = {a}");
        }

        [HttpPut]
        public ActionResult<string> Put([FromBody] int a, [FromQuery] int b)
        {
            return $"a = {a}, b = {b}";
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] int a, [FromQuery] int b)
        {
            return $"a = {a}, b = {b}";
        }


        [HttpDelete]
        public ActionResult<string> Delete([FromBody] int a, [FromQuery] int b)
        {
            return $"a = {a}, b = {b}";
        }

    }
}
