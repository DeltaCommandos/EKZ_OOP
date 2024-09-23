using EKZ20B.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EKZ20B.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Puller()
        {
            using (HttpClient client = new HttpClient())
            {
                var output = client.GetAsync("https://localhost:7094/api/Push").Result.Content.ReadAsStringAsync();
                return Ok(output);
            }
        }
    }
}
